
namespace PROIECT
{
    partial class Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.p = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.print = new System.Windows.Forms.ToolStripButton();
            this.ink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shapes = new System.Windows.Forms.ToolStripDropDownButton();
            this.number = new System.Windows.Forms.ToolStripTextBox();
            this.play = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.color = new System.Windows.Forms.ToolStripButton();
            this.fill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.info = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cd = new System.Windows.Forms.ColorDialog();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p.Location = new System.Drawing.Point(35, 97);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(879, 406);
            this.p.TabIndex = 0;
            this.p.TabStop = false;
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Paint);
            this.p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancel,
            this.toolStripSeparator3,
            this.save,
            this.print,
            this.ink,
            this.toolStripSeparator1,
            this.shapes,
            this.number,
            this.play,
            this.toolStripSeparator2,
            this.color,
            this.fill,
            this.toolStripSeparator5,
            this.info,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(947, 71);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cancel
            // 
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = global::PROIECT.Properties.Resources.cancelled;
            this.cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 68);
            this.cancel.Text = "clear";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = global::PROIECT.Properties.Resources.save__2_;
            this.save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 68);
            this.save.Text = "save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // print
            // 
            this.print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print.Image = global::PROIECT.Properties.Resources.printer;
            this.print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(68, 68);
            this.print.Text = "print";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // ink
            // 
            this.ink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ink.Image = global::PROIECT.Properties.Resources.watering;
            this.ink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ink.Name = "ink";
            this.ink.Size = new System.Drawing.Size(68, 68);
            this.ink.Text = "ink";
            this.ink.Click += new System.EventHandler(this.ink_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // shapes
            // 
            this.shapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shapes.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shapes.Image = global::PROIECT.Properties.Resources.shapes;
            this.shapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(78, 68);
            this.shapes.Text = "shapes";
            this.shapes.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.shapes_DropDownItemClicked);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.number.ForeColor = System.Drawing.SystemColors.GrayText;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 71);
            // 
            // play
            // 
            this.play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.play.Image = global::PROIECT.Properties.Resources.play;
            this.play.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(68, 68);
            this.play.Text = "play";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // color
            // 
            this.color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.color.Image = global::PROIECT.Properties.Resources.color_palette;
            this.color.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(68, 68);
            this.color.Text = "color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // fill
            // 
            this.fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fill.Image = global::PROIECT.Properties.Resources.paint_bucket;
            this.fill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(68, 68);
            this.fill.Text = "fill";
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 71);
            // 
            // info
            // 
            this.info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.info.Image = global::PROIECT.Properties.Resources.info;
            this.info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.info.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(68, 68);
            this.info.Text = "info";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "line.png");
            this.imageList.Images.SetKeyName(1, "pythagoras.png");
            this.imageList.Images.SetKeyName(2, "ellipse.png");
            this.imageList.Images.SetKeyName(3, "rectangle.png");
            this.imageList.Images.SetKeyName(4, "line (1).png");
            this.imageList.Images.SetKeyName(5, "save.png");
            // 
            // pd
            // 
            this.pd.Document = this.printDocument1;
            this.pd.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Picturi abstracte";
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton print;
        private System.Windows.Forms.ToolStripButton ink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripTextBox number;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton color;
        private System.Windows.Forms.ToolStripButton fill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton info;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton play;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripDropDownButton shapes;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.SaveFileDialog sf;
        private System.Windows.Forms.PrintDialog pd;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

