namespace MyBD
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планСчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гсмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркагсмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналОперацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПроводокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.журналОперацийToolStripMenuItem,
            this.журналПроводокToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планСчетовToolStripMenuItem,
            this.водительToolStripMenuItem,
            this.машинаToolStripMenuItem,
            this.гсмToolStripMenuItem,
            this.маркагсмToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // планСчетовToolStripMenuItem
            // 
            this.планСчетовToolStripMenuItem.Name = "планСчетовToolStripMenuItem";
            this.планСчетовToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.планСчетовToolStripMenuItem.Text = "План счетов";
            this.планСчетовToolStripMenuItem.Click += new System.EventHandler(this.планСчетовToolStripMenuItem_Click);
            // 
            // водительToolStripMenuItem
            // 
            this.водительToolStripMenuItem.Name = "водительToolStripMenuItem";
            this.водительToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.водительToolStripMenuItem.Text = "Водитель";
            this.водительToolStripMenuItem.Click += new System.EventHandler(this.водительToolStripMenuItem_Click);
            // 
            // машинаToolStripMenuItem
            // 
            this.машинаToolStripMenuItem.Name = "машинаToolStripMenuItem";
            this.машинаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.машинаToolStripMenuItem.Text = "Машина";
            this.машинаToolStripMenuItem.Click += new System.EventHandler(this.машинаToolStripMenuItem_Click);
            // 
            // гсмToolStripMenuItem
            // 
            this.гсмToolStripMenuItem.Name = "гсмToolStripMenuItem";
            this.гсмToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.гсмToolStripMenuItem.Text = "ГСМ";
            this.гсмToolStripMenuItem.Click += new System.EventHandler(this.гсмToolStripMenuItem_Click);
            // 
            // маркагсмToolStripMenuItem
            // 
            this.маркагсмToolStripMenuItem.Name = "маркагсмToolStripMenuItem";
            this.маркагсмToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.маркагсмToolStripMenuItem.Text = "Марка ГСМ";
            this.маркагсмToolStripMenuItem.Click += new System.EventHandler(this.маркагсмToolStripMenuItem_Click);
            // 
            // журналОперацийToolStripMenuItem
            // 
            this.журналОперацийToolStripMenuItem.Name = "журналОперацийToolStripMenuItem";
            this.журналОперацийToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.журналОперацийToolStripMenuItem.Text = "Журнал операций";
            this.журналОперацийToolStripMenuItem.Click += new System.EventHandler(this.журналОперацийToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // журналПроводокToolStripMenuItem
            // 
            this.журналПроводокToolStripMenuItem.Name = "журналПроводокToolStripMenuItem";
            this.журналПроводокToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.журналПроводокToolStripMenuItem.Text = "Журнал проводок";
            this.журналПроводокToolStripMenuItem.Click += new System.EventHandler(this.журналПроводокToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 881);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Учет ГСМ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планСчетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналОперацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гсмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркагсмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналПроводокToolStripMenuItem;
    }
}