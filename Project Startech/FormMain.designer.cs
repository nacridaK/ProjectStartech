namespace Project_Startech
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SeriPort = new System.IO.Ports.SerialPort(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.zedGraphKontrol01 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol02 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol03 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol04 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol05 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol06 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol07 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol08 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol09 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol10 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol11 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.zedGraphKontrol12 = new ZedGraphKutuphanesi.ZedGraphKontrol();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.elementHost_Ribbon = new System.Windows.Forms.Integration.ElementHost();
            this.Ribbon = new RibbonLib.Ribbonlar.RibbonControl();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeriPort
            // 
            this.SeriPort.BaudRate = 4800;
            this.SeriPort.PortName = "COM4";
            this.SeriPort.ReceivedBytesThreshold = 12;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 116);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1225, 492);
            this.panel_main.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer5);
            this.panel2.Controls.Add(this.splitter4);
            this.panel2.Controls.Add(this.splitContainer6);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Controls.Add(this.splitContainer4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 492);
            this.panel2.TabIndex = 6;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 165);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.zedGraphKontrol09);
            this.splitContainer5.Panel1MinSize = 0;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.zedGraphKontrol10);
            this.splitContainer5.Panel2MinSize = 0;
            this.splitContainer5.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer5.SplitterDistance = 610;
            this.splitContainer5.TabIndex = 11;
            // 
            // zedGraphKontrol09
            // 
            this.zedGraphKontrol09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol09.GecmisiIncele = false;
            this.zedGraphKontrol09.IsEnableHPan = false;
            this.zedGraphKontrol09.IsEnableHZoom = false;
            this.zedGraphKontrol09.IsEnableVZoom = false;
            this.zedGraphKontrol09.IsShowContextMenu = false;
            this.zedGraphKontrol09.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol09.Name = "zedGraphKontrol09";
            this.zedGraphKontrol09.ScrollGrace = 0D;
            this.zedGraphKontrol09.ScrollMaxX = 0D;
            this.zedGraphKontrol09.ScrollMaxY = 0D;
            this.zedGraphKontrol09.ScrollMaxY2 = 0D;
            this.zedGraphKontrol09.ScrollMinX = 0D;
            this.zedGraphKontrol09.ScrollMinY = 0D;
            this.zedGraphKontrol09.ScrollMinY2 = 0D;
            this.zedGraphKontrol09.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol09.TabIndex = 9;
            this.zedGraphKontrol09.TabStop = false;
            this.zedGraphKontrol09.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol09.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol10
            // 
            this.zedGraphKontrol10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol10.GecmisiIncele = false;
            this.zedGraphKontrol10.IsEnableHPan = false;
            this.zedGraphKontrol10.IsEnableHZoom = false;
            this.zedGraphKontrol10.IsEnableVZoom = false;
            this.zedGraphKontrol10.IsShowContextMenu = false;
            this.zedGraphKontrol10.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol10.Name = "zedGraphKontrol10";
            this.zedGraphKontrol10.ScrollGrace = 0D;
            this.zedGraphKontrol10.ScrollMaxX = 0D;
            this.zedGraphKontrol10.ScrollMaxY = 0D;
            this.zedGraphKontrol10.ScrollMaxY2 = 0D;
            this.zedGraphKontrol10.ScrollMinX = 0D;
            this.zedGraphKontrol10.ScrollMinY = 0D;
            this.zedGraphKontrol10.ScrollMinY2 = 0D;
            this.zedGraphKontrol10.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol10.TabIndex = 10;
            this.zedGraphKontrol10.TabStop = false;
            this.zedGraphKontrol10.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol10.UseExtendedPrintDialog = true;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(0, 327);
            this.splitter4.MinExtra = 0;
            this.splitter4.MinSize = 0;
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1225, 3);
            this.splitter4.TabIndex = 10;
            this.splitter4.TabStop = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer6.Location = new System.Drawing.Point(0, 330);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.zedGraphKontrol11);
            this.splitContainer6.Panel1MinSize = 0;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.zedGraphKontrol12);
            this.splitContainer6.Panel2MinSize = 0;
            this.splitContainer6.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer6.SplitterDistance = 610;
            this.splitContainer6.TabIndex = 7;
            // 
            // zedGraphKontrol11
            // 
            this.zedGraphKontrol11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol11.GecmisiIncele = false;
            this.zedGraphKontrol11.IsEnableHPan = false;
            this.zedGraphKontrol11.IsEnableHZoom = false;
            this.zedGraphKontrol11.IsEnableVZoom = false;
            this.zedGraphKontrol11.IsShowContextMenu = false;
            this.zedGraphKontrol11.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol11.Name = "zedGraphKontrol11";
            this.zedGraphKontrol11.ScrollGrace = 0D;
            this.zedGraphKontrol11.ScrollMaxX = 0D;
            this.zedGraphKontrol11.ScrollMaxY = 0D;
            this.zedGraphKontrol11.ScrollMaxY2 = 0D;
            this.zedGraphKontrol11.ScrollMinX = 0D;
            this.zedGraphKontrol11.ScrollMinY = 0D;
            this.zedGraphKontrol11.ScrollMinY2 = 0D;
            this.zedGraphKontrol11.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol11.TabIndex = 11;
            this.zedGraphKontrol11.TabStop = false;
            this.zedGraphKontrol11.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol11.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol12
            // 
            this.zedGraphKontrol12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol12.GecmisiIncele = false;
            this.zedGraphKontrol12.IsEnableHPan = false;
            this.zedGraphKontrol12.IsEnableHZoom = false;
            this.zedGraphKontrol12.IsEnableVZoom = false;
            this.zedGraphKontrol12.IsShowContextMenu = false;
            this.zedGraphKontrol12.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol12.Name = "zedGraphKontrol12";
            this.zedGraphKontrol12.ScrollGrace = 0D;
            this.zedGraphKontrol12.ScrollMaxX = 0D;
            this.zedGraphKontrol12.ScrollMaxY = 0D;
            this.zedGraphKontrol12.ScrollMaxY2 = 0D;
            this.zedGraphKontrol12.ScrollMinX = 0D;
            this.zedGraphKontrol12.ScrollMinY = 0D;
            this.zedGraphKontrol12.ScrollMinY2 = 0D;
            this.zedGraphKontrol12.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol12.TabIndex = 12;
            this.zedGraphKontrol12.TabStop = false;
            this.zedGraphKontrol12.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol12.UseExtendedPrintDialog = true;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 162);
            this.splitter3.MinExtra = 0;
            this.splitter3.MinSize = 0;
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1225, 3);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.zedGraphKontrol07);
            this.splitContainer4.Panel1MinSize = 0;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.zedGraphKontrol08);
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer4.SplitterDistance = 610;
            this.splitContainer4.TabIndex = 3;
            // 
            // zedGraphKontrol07
            // 
            this.zedGraphKontrol07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol07.GecmisiIncele = false;
            this.zedGraphKontrol07.IsEnableHPan = false;
            this.zedGraphKontrol07.IsEnableHZoom = false;
            this.zedGraphKontrol07.IsEnableVZoom = false;
            this.zedGraphKontrol07.IsShowContextMenu = false;
            this.zedGraphKontrol07.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol07.Name = "zedGraphKontrol07";
            this.zedGraphKontrol07.ScrollGrace = 0D;
            this.zedGraphKontrol07.ScrollMaxX = 0D;
            this.zedGraphKontrol07.ScrollMaxY = 0D;
            this.zedGraphKontrol07.ScrollMaxY2 = 0D;
            this.zedGraphKontrol07.ScrollMinX = 0D;
            this.zedGraphKontrol07.ScrollMinY = 0D;
            this.zedGraphKontrol07.ScrollMinY2 = 0D;
            this.zedGraphKontrol07.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol07.TabIndex = 7;
            this.zedGraphKontrol07.TabStop = false;
            this.zedGraphKontrol07.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol07.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol08
            // 
            this.zedGraphKontrol08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol08.GecmisiIncele = false;
            this.zedGraphKontrol08.IsEnableHPan = false;
            this.zedGraphKontrol08.IsEnableHZoom = false;
            this.zedGraphKontrol08.IsEnableVZoom = false;
            this.zedGraphKontrol08.IsShowContextMenu = false;
            this.zedGraphKontrol08.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol08.Name = "zedGraphKontrol08";
            this.zedGraphKontrol08.ScrollGrace = 0D;
            this.zedGraphKontrol08.ScrollMaxX = 0D;
            this.zedGraphKontrol08.ScrollMaxY = 0D;
            this.zedGraphKontrol08.ScrollMaxY2 = 0D;
            this.zedGraphKontrol08.ScrollMinX = 0D;
            this.zedGraphKontrol08.ScrollMinY = 0D;
            this.zedGraphKontrol08.ScrollMinY2 = 0D;
            this.zedGraphKontrol08.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol08.TabIndex = 8;
            this.zedGraphKontrol08.TabStop = false;
            this.zedGraphKontrol08.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol08.UseExtendedPrintDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 492);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 165);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.zedGraphKontrol03);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGraphKontrol04);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer2.SplitterDistance = 610;
            this.splitContainer2.TabIndex = 11;
            // 
            // zedGraphKontrol03
            // 
            this.zedGraphKontrol03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol03.GecmisiIncele = false;
            this.zedGraphKontrol03.IsEnableHPan = false;
            this.zedGraphKontrol03.IsEnableHZoom = false;
            this.zedGraphKontrol03.IsEnableVZoom = false;
            this.zedGraphKontrol03.IsShowContextMenu = false;
            this.zedGraphKontrol03.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol03.Name = "zedGraphKontrol03";
            this.zedGraphKontrol03.ScrollGrace = 0D;
            this.zedGraphKontrol03.ScrollMaxX = 0D;
            this.zedGraphKontrol03.ScrollMaxY = 0D;
            this.zedGraphKontrol03.ScrollMaxY2 = 0D;
            this.zedGraphKontrol03.ScrollMinX = 0D;
            this.zedGraphKontrol03.ScrollMinY = 0D;
            this.zedGraphKontrol03.ScrollMinY2 = 0D;
            this.zedGraphKontrol03.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol03.TabIndex = 3;
            this.zedGraphKontrol03.TabStop = false;
            this.zedGraphKontrol03.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol03.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol04
            // 
            this.zedGraphKontrol04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol04.GecmisiIncele = false;
            this.zedGraphKontrol04.IsEnableHPan = false;
            this.zedGraphKontrol04.IsEnableHZoom = false;
            this.zedGraphKontrol04.IsEnableVZoom = false;
            this.zedGraphKontrol04.IsShowContextMenu = false;
            this.zedGraphKontrol04.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol04.Name = "zedGraphKontrol04";
            this.zedGraphKontrol04.ScrollGrace = 0D;
            this.zedGraphKontrol04.ScrollMaxX = 0D;
            this.zedGraphKontrol04.ScrollMaxY = 0D;
            this.zedGraphKontrol04.ScrollMaxY2 = 0D;
            this.zedGraphKontrol04.ScrollMinX = 0D;
            this.zedGraphKontrol04.ScrollMinY = 0D;
            this.zedGraphKontrol04.ScrollMinY2 = 0D;
            this.zedGraphKontrol04.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol04.TabIndex = 4;
            this.zedGraphKontrol04.TabStop = false;
            this.zedGraphKontrol04.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol04.UseExtendedPrintDialog = true;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 327);
            this.splitter2.MinExtra = 0;
            this.splitter2.MinSize = 0;
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1225, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer3.Location = new System.Drawing.Point(0, 330);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.zedGraphKontrol05);
            this.splitContainer3.Panel1MinSize = 0;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.zedGraphKontrol06);
            this.splitContainer3.Panel2MinSize = 0;
            this.splitContainer3.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer3.SplitterDistance = 610;
            this.splitContainer3.TabIndex = 7;
            // 
            // zedGraphKontrol05
            // 
            this.zedGraphKontrol05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol05.GecmisiIncele = false;
            this.zedGraphKontrol05.IsEnableHPan = false;
            this.zedGraphKontrol05.IsEnableHZoom = false;
            this.zedGraphKontrol05.IsEnableVZoom = false;
            this.zedGraphKontrol05.IsShowContextMenu = false;
            this.zedGraphKontrol05.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol05.Name = "zedGraphKontrol05";
            this.zedGraphKontrol05.ScrollGrace = 0D;
            this.zedGraphKontrol05.ScrollMaxX = 0D;
            this.zedGraphKontrol05.ScrollMaxY = 0D;
            this.zedGraphKontrol05.ScrollMaxY2 = 0D;
            this.zedGraphKontrol05.ScrollMinX = 0D;
            this.zedGraphKontrol05.ScrollMinY = 0D;
            this.zedGraphKontrol05.ScrollMinY2 = 0D;
            this.zedGraphKontrol05.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol05.TabIndex = 5;
            this.zedGraphKontrol05.TabStop = false;
            this.zedGraphKontrol05.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol05.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol06
            // 
            this.zedGraphKontrol06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol06.GecmisiIncele = false;
            this.zedGraphKontrol06.IsEnableHPan = false;
            this.zedGraphKontrol06.IsEnableHZoom = false;
            this.zedGraphKontrol06.IsEnableVZoom = false;
            this.zedGraphKontrol06.IsShowContextMenu = false;
            this.zedGraphKontrol06.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol06.Name = "zedGraphKontrol06";
            this.zedGraphKontrol06.ScrollGrace = 0D;
            this.zedGraphKontrol06.ScrollMaxX = 0D;
            this.zedGraphKontrol06.ScrollMaxY = 0D;
            this.zedGraphKontrol06.ScrollMaxY2 = 0D;
            this.zedGraphKontrol06.ScrollMinX = 0D;
            this.zedGraphKontrol06.ScrollMinY = 0D;
            this.zedGraphKontrol06.ScrollMinY2 = 0D;
            this.zedGraphKontrol06.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol06.TabIndex = 6;
            this.zedGraphKontrol06.TabStop = false;
            this.zedGraphKontrol06.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol06.UseExtendedPrintDialog = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 162);
            this.splitter1.MinExtra = 0;
            this.splitter1.MinSize = 0;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1225, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zedGraphKontrol01);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.zedGraphKontrol02);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1225, 162);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.TabIndex = 3;
            // 
            // zedGraphKontrol01
            // 
            this.zedGraphKontrol01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol01.GecmisiIncele = false;
            this.zedGraphKontrol01.IsEnableHPan = false;
            this.zedGraphKontrol01.IsEnableHZoom = false;
            this.zedGraphKontrol01.IsEnableVZoom = false;
            this.zedGraphKontrol01.IsShowContextMenu = false;
            this.zedGraphKontrol01.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol01.Name = "zedGraphKontrol01";
            this.zedGraphKontrol01.ScrollGrace = 0D;
            this.zedGraphKontrol01.ScrollMaxX = 0D;
            this.zedGraphKontrol01.ScrollMaxY = 0D;
            this.zedGraphKontrol01.ScrollMaxY2 = 0D;
            this.zedGraphKontrol01.ScrollMinX = 0D;
            this.zedGraphKontrol01.ScrollMinY = 0D;
            this.zedGraphKontrol01.ScrollMinY2 = 0D;
            this.zedGraphKontrol01.Size = new System.Drawing.Size(610, 162);
            this.zedGraphKontrol01.TabIndex = 1;
            this.zedGraphKontrol01.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol01.UseExtendedPrintDialog = true;
            // 
            // zedGraphKontrol02
            // 
            this.zedGraphKontrol02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphKontrol02.GecmisiIncele = false;
            this.zedGraphKontrol02.IsEnableHPan = false;
            this.zedGraphKontrol02.IsEnableHZoom = false;
            this.zedGraphKontrol02.IsEnableVZoom = false;
            this.zedGraphKontrol02.IsShowContextMenu = false;
            this.zedGraphKontrol02.Location = new System.Drawing.Point(0, 0);
            this.zedGraphKontrol02.Name = "zedGraphKontrol02";
            this.zedGraphKontrol02.ScrollGrace = 0D;
            this.zedGraphKontrol02.ScrollMaxX = 0D;
            this.zedGraphKontrol02.ScrollMaxY = 0D;
            this.zedGraphKontrol02.ScrollMaxY2 = 0D;
            this.zedGraphKontrol02.ScrollMinX = 0D;
            this.zedGraphKontrol02.ScrollMinY = 0D;
            this.zedGraphKontrol02.ScrollMinY2 = 0D;
            this.zedGraphKontrol02.Size = new System.Drawing.Size(611, 162);
            this.zedGraphKontrol02.TabIndex = 2;
            this.zedGraphKontrol02.Tur = ZedGraphKutuphanesi.VeriIslemleri.VeriTuru.Byte;
            this.zedGraphKontrol02.UseExtendedPrintDialog = true;
            // 
            // elementHost_Ribbon
            // 
            this.elementHost_Ribbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost_Ribbon.Location = new System.Drawing.Point(0, 0);
            this.elementHost_Ribbon.Name = "elementHost_Ribbon";
            this.elementHost_Ribbon.Size = new System.Drawing.Size(1225, 116);
            this.elementHost_Ribbon.TabIndex = 4;
            this.elementHost_Ribbon.Text = "Ribbon";
            this.elementHost_Ribbon.Child = this.Ribbon;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 608);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.elementHost_Ribbon);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Startech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeriPortKontrolu);
            this.panel_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort SeriPort;
        private System.Windows.Forms.Integration.ElementHost elementHost_Ribbon;
        private RibbonLib.Ribbonlar.RibbonControl Ribbon;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol01;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol02;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol03;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol04;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol05;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol06;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel2;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol07;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol08;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol09;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol10;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol11;
        private ZedGraphKutuphanesi.ZedGraphKontrol zedGraphKontrol12;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
    }
}

