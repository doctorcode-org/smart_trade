using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using SmartTrade.Infrastructure;
using SmartTrade.Models;
using System.Net.Http.Json;

namespace SmartTrade
{
    public partial class Login : Form
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMemoryCache _cache;
        private Form _orderForm;

        public Login(IHttpClientFactory clientFactory, IServiceProvider serviceProvider, IMemoryCache cache)
        {
            InitializeComponent();

            _clientFactory = clientFactory;
            _serviceProvider = serviceProvider;
            _cache = cache;
        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using var client = _clientFactory.CreateClient(Constants.SmartClient);
                using var response = await client.PostJsonAsync($"/account/login", new
                {
                    LoginType = 1,
                    Username = Username.Text,
                    Password = Password.Text,
                    CaptchaCode = CaptchaCode.Text
                });
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<ApiResult<LoginResponse>>();
                if (result.Success)
                {
                    //TODO: Add expire date
                    _cache.Set(Constants.AccessToken, result.Data.AccessToken);
                    Hide();

                    _orderForm = _serviceProvider.GetRequiredService<OrderForm>();
                    _orderForm.Show(this);
                }
                else
                {
                    MessageBox.Show($"عملیات ورود موفق نبود.\r\n{string.Join("\r\n", result.Errors)}");
                }
            }
            catch (Exception ex)
            {
                ShowError("عملیات ورود با خطا مواجه شد.", ex);
            }
        }

        private async Task RefreshCaptchaAsync()
        {
            try
            {
                CaptchaCode.Text = "";
                using var client = _clientFactory.CreateClient(Constants.SmartClient);
                using var response = await client.GetAsync($"/account/captcha?d={DateTime.Now.Ticks}");
                response.EnsureSuccessStatusCode();
                using var stream = await response.Content.ReadAsStreamAsync();
                CaptchaImage.Image = Image.FromStream(stream, false, true);
            }
            catch (Exception ex)
            {
                ShowError("دریافت کد امنیتی با خطا مواجه شد.", ex);
            }
        }

        private async void CaptchaImage_Click(object sender, EventArgs e)
        {
            await RefreshCaptchaAsync();
        }

        private static void ShowError(string message, Exception exception)
        {
            MessageBox.Show($"{message}\r\n{exception.Message}");
        }

        private async void Login_Shown(object sender, EventArgs e)
        {
            var task = Task.Run(RefreshCaptchaAsync);
            _orderForm?.Close();
            _orderForm?.Dispose();
            _orderForm = null;
            await task;
        }
    }
}
