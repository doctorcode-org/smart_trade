using SmartTrade.Infrastructure;
using SmartTrade.Models;

namespace SmartTrade
{
    public partial class OrderForm : Form
    {
        private bool _started;
        private TimeSpan _delay;
        private OrderRequest _order;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly TimeSpan _startTime = new(hours: 8, minutes: 44, seconds: 58);
        private readonly TimeSpan _endTime = new(hours: 8, minutes: 45, seconds: 1);

        private readonly IHttpClientFactory _clientFactory;

        public OrderForm(IHttpClientFactory clientFactory)
        {
            InitializeComponent();
            _clientFactory = clientFactory;
            Task.Run(SyncTime);
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClockTimer.Stop();
            ClockTimer.Dispose();
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            Owner.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveRequest_Click(object sender, EventArgs e)
        {
            _order = new OrderRequest
            {
                InstrumentId = InstrumentId.Text,
                Price = decimal.Parse(Price.Text),
                Quantity = int.Parse(Quantity.Text),
                OrderSide = OrderSide.Text == "خرید" ? 1 : 2
            };

            SaveRequest.Enabled = false;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.Add(_delay).TimeOfDay;
            Clock.Text = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}";

            if (_started)
            {
                if (time > _endTime)
                {
                    _order = null;
                    _cancellationTokenSource.Cancel();
                    SaveRequest.Enabled = true;
                }
            }
            else if (_order is not null && time >= _startTime && time <= _endTime)
            {
                _cancellationTokenSource = new CancellationTokenSource();
                Task.Run(SendOrderAsync, _cancellationTokenSource.Token);
            }
        }

        private async Task SyncTime()
        {
            try
            {
                using var client = _clientFactory.CreateClient(Constants.CoreClient);
                var t0 = DateTime.Now;
                var response = await client.GetAsync("/ntp");
                var t3 = DateTime.Now;
                response.EnsureSuccessStatusCode();
                var ticks = long.Parse(response.Headers.GetValues("X-SERVER-TIME").FirstOrDefault());
                var t1 = new DateTime(DateTime.UnixEpoch.Ticks + (DateTime.Now.Ticks - DateTime.UtcNow.Ticks) + (ticks * 10_000), DateTimeKind.Utc);
                _delay = t1 - t3 + (t3 - t0);
            }
            catch (Exception)
            {

            }
        }

        private async Task SendOrderAsync()
        {
            _started = true;
            using var client = _clientFactory.CreateClient(Constants.CoreClient);
            {
                while (!_cancellationTokenSource.IsCancellationRequested)
                {
                    try
                    {
                        var response = await client.PostJsonAsync("/v1/Requests/SaveRequest", _order, _cancellationTokenSource.Token);
                        response.EnsureSuccessStatusCode();
                        var result = await response.Content.ReadAsStringAsync(_cancellationTokenSource.Token);
                        //TODO: Log result
                    }
                    catch (Exception ex)
                    {

                    }

                    await Task.Delay(300, _cancellationTokenSource.Token);
                }
            }
        }
    }
}
