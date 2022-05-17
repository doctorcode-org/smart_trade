namespace SmartTrade
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.InstrumentId = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderSide = new System.Windows.Forms.ComboBox();
            this.SaveRequest = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.Clock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نماد:";
            // 
            // InstrumentId
            // 
            this.InstrumentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstrumentId.Location = new System.Drawing.Point(230, 22);
            this.InstrumentId.Name = "InstrumentId";
            this.InstrumentId.Size = new System.Drawing.Size(132, 23);
            this.InstrumentId.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Location = new System.Drawing.Point(230, 56);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(132, 23);
            this.Quantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد:";
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Location = new System.Drawing.Point(230, 87);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(132, 23);
            this.Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "قیمت:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 124);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع سفارش:";
            // 
            // OrderSide
            // 
            this.OrderSide.FormattingEnabled = true;
            this.OrderSide.Items.AddRange(new object[] {
            "خرید",
            "فروش"});
            this.OrderSide.Location = new System.Drawing.Point(230, 121);
            this.OrderSide.Name = "OrderSide";
            this.OrderSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderSide.Size = new System.Drawing.Size(132, 23);
            this.OrderSide.TabIndex = 7;
            this.OrderSide.Text = "خرید";
            // 
            // SaveRequest
            // 
            this.SaveRequest.Location = new System.Drawing.Point(230, 164);
            this.SaveRequest.Name = "SaveRequest";
            this.SaveRequest.Size = new System.Drawing.Size(132, 44);
            this.SaveRequest.TabIndex = 8;
            this.SaveRequest.Text = "ثبت سفارش";
            this.SaveRequest.UseVisualStyleBackColor = true;
            this.SaveRequest.Click += new System.EventHandler(this.SaveRequest_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clock.Location = new System.Drawing.Point(12, 171);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(88, 25);
            this.Clock.TabIndex = 9;
            this.Clock.Text = "00:00:00";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 381);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.SaveRequest);
            this.Controls.Add(this.OrderSide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstrumentId);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox InstrumentId;
        private TextBox Quantity;
        private Label label2;
        private TextBox Price;
        private Label label3;
        private Label label4;
        private ComboBox OrderSide;
        private Button SaveRequest;
        private System.Windows.Forms.Timer ClockTimer;
        private Label Clock;
    }
}