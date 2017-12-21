using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EZFlow
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmEZFlow : System.Windows.Forms.Form
	{
		private Pronexus.VBVoice.VBVFrame vbvFrame1;
		private Pronexus.VBVoice.LineGroup PhoneAns;
		private Pronexus.VBVoice.PlayGreeting IntroGreeting;
		private Pronexus.VBVoice.GetDigits GetCustInfo;
		private Pronexus.VBVoice.OnHook onHook1;
		private Pronexus.VBVoice.PlayGreeting ProductInfo;
		private Pronexus.VBVoice.PlayGreeting SupportInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdStart;
		private System.Windows.Forms.Button cmdStop;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEZFlow()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEZFlow));
            this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
            this.PhoneAns = new Pronexus.VBVoice.LineGroup();
            this.IntroGreeting = new Pronexus.VBVoice.PlayGreeting();
            this.GetCustInfo = new Pronexus.VBVoice.GetDigits();
            this.onHook1 = new Pronexus.VBVoice.OnHook();
            this.ProductInfo = new Pronexus.VBVoice.PlayGreeting();
            this.SupportInfo = new Pronexus.VBVoice.PlayGreeting();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
            this.vbvFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroGreeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCustInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // vbvFrame1
            // 
            this.vbvFrame1.Controls.Add(this.PhoneAns);
            this.vbvFrame1.Controls.Add(this.IntroGreeting);
            this.vbvFrame1.Controls.Add(this.GetCustInfo);
            this.vbvFrame1.Controls.Add(this.onHook1);
            this.vbvFrame1.Controls.Add(this.ProductInfo);
            this.vbvFrame1.Controls.Add(this.SupportInfo);
            this.vbvFrame1.Location = new System.Drawing.Point(0, 0);
            this.vbvFrame1.Name = "vbvFrame1";
            this.vbvFrame1.PropertyBag = resources.GetString("vbvFrame1.PropertyBag");
            this.vbvFrame1.Size = new System.Drawing.Size(560, 224);
            this.vbvFrame1.TabIndex = 0;
            // 
            // PhoneAns
            // 
            this.PhoneAns.Location = new System.Drawing.Point(8, 88);
            this.PhoneAns.Name = "PhoneAns";
            this.PhoneAns.PropertyBag = resources.GetString("PhoneAns.PropertyBag");
            this.PhoneAns.TabIndex = 1;
            // 
            // IntroGreeting
            // 
            this.IntroGreeting.Location = new System.Drawing.Point(96, 88);
            this.IntroGreeting.Name = "IntroGreeting";
            this.IntroGreeting.PropertyBag = resources.GetString("IntroGreeting.PropertyBag");
            this.IntroGreeting.TabIndex = 2;
            // 
            // GetCustInfo
            // 
            this.GetCustInfo.Location = new System.Drawing.Point(208, 88);
            this.GetCustInfo.Name = "GetCustInfo";
            this.GetCustInfo.PropertyBag = resources.GetString("GetCustInfo.PropertyBag");
            this.GetCustInfo.TabIndex = 3;
            // 
            // onHook1
            // 
            this.onHook1.Location = new System.Drawing.Point(464, 96);
            this.onHook1.Name = "onHook1";
            this.onHook1.PropertyBag = resources.GetString("onHook1.PropertyBag");
            this.onHook1.TabIndex = 4;
            // 
            // ProductInfo
            // 
            this.ProductInfo.Location = new System.Drawing.Point(376, 40);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.PropertyBag = resources.GetString("ProductInfo.PropertyBag");
            this.ProductInfo.TabIndex = 5;
            // 
            // SupportInfo
            // 
            this.SupportInfo.Location = new System.Drawing.Point(376, 136);
            this.SupportInfo.Name = "SupportInfo";
            this.SupportInfo.PropertyBag = resources.GetString("SupportInfo.PropertyBag");
            this.SupportInfo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "This example displays the ease in which a simple IVR application  can be created." +
                " A user dials in and is offered two information options.";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(400, 232);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 8;
            this.cmdStart.Text = "&Start";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(480, 232);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 9;
            this.cmdStop.Text = "S&top";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // frmEZFlow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(560, 267);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vbvFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEZFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#.NET - EZFlow Example";
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
            this.vbvFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroGreeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCustInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportInfo)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmEZFlow());
		}

		private void cmdStart_Click(object sender, System.EventArgs e)
		{
			if(!vbvFrame1.SystemStarted())
			{
				vbvFrame1.StartSystem(true);
				cmdStart.Enabled = false;
				cmdStop.Enabled = true;
			}
		}

		private void cmdStop_Click(object sender, System.EventArgs e)
		{
			if(vbvFrame1.SystemStarted()) 
			{
				vbvFrame1.StopSystem(true);
				cmdStart.Enabled = true;
				cmdStop.Enabled = false;
			}
		}
	}
}
