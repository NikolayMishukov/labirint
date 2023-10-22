namespace labirint
{
    partial class Labirint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirint));
            this.pnlLabir = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lblSch = new System.Windows.Forms.Label();
            this.lblwal = new System.Windows.Forms.Label();
            this.lblBoom = new System.Windows.Forms.Label();
            this.lblinv = new System.Windows.Forms.Label();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tmrBomb = new System.Windows.Forms.Timer(this.components);
            this.pnlCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabir
            // 
            this.pnlLabir.Location = new System.Drawing.Point(12, 12);
            this.pnlLabir.Name = "pnlLabir";
            this.pnlLabir.Size = new System.Drawing.Size(404, 404);
            this.pnlLabir.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 435);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Начало";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(255, 435);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(131, 55);
            this.btnAgain.TabIndex = 0;
            this.btnAgain.TabStop = false;
            this.btnAgain.Text = "Заново";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.BtnAgain_Click);
            // 
            // lblSch
            // 
            this.lblSch.AutoSize = true;
            this.lblSch.Location = new System.Drawing.Point(7, 3);
            this.lblSch.Name = "lblSch";
            this.lblSch.Size = new System.Drawing.Size(33, 13);
            this.lblSch.TabIndex = 3;
            this.lblSch.Text = "Счёт:";
            // 
            // lblwal
            // 
            this.lblwal.AutoSize = true;
            this.lblwal.Location = new System.Drawing.Point(46, 3);
            this.lblwal.Name = "lblwal";
            this.lblwal.Size = new System.Drawing.Size(19, 13);
            this.lblwal.TabIndex = 4;
            this.lblwal.Text = "0$";
            // 
            // lblBoom
            // 
            this.lblBoom.AutoSize = true;
            this.lblBoom.Location = new System.Drawing.Point(84, 3);
            this.lblBoom.Name = "lblBoom";
            this.lblBoom.Size = new System.Drawing.Size(107, 13);
            this.lblBoom.TabIndex = 5;
            this.lblBoom.Text = "Кол-во взрывчатки:";
            // 
            // lblinv
            // 
            this.lblinv.AutoSize = true;
            this.lblinv.Location = new System.Drawing.Point(196, 3);
            this.lblinv.Name = "lblinv";
            this.lblinv.Size = new System.Drawing.Size(29, 13);
            this.lblinv.TabIndex = 6;
            this.lblinv.Text = "0 шт";
            // 
            // pnlCont
            // 
            this.pnlCont.Controls.Add(this.btnShop);
            this.pnlCont.Controls.Add(this.btnMenu);
            this.pnlCont.Controls.Add(this.btninfo);
            this.pnlCont.Controls.Add(this.btnSave);
            this.pnlCont.Controls.Add(this.btnLoad);
            this.pnlCont.Controls.Add(this.lblinv);
            this.pnlCont.Controls.Add(this.lblBoom);
            this.pnlCont.Controls.Add(this.lblwal);
            this.pnlCont.Controls.Add(this.lblSch);
            this.pnlCont.Location = new System.Drawing.Point(81, 496);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(305, 47);
            this.pnlCont.TabIndex = 7;
            this.pnlCont.Visible = false;
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = global::labirint.Properties.Resources.shop;
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Location = new System.Drawing.Point(231, 3);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(40, 40);
            this.btnShop.TabIndex = 0;
            this.btnShop.TabStop = false;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::labirint.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(277, 23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninfo
            // 
            this.btninfo.BackgroundImage = global::labirint.Properties.Resources.info;
            this.btninfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.Location = new System.Drawing.Point(277, 3);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(20, 20);
            this.btninfo.TabIndex = 0;
            this.btninfo.TabStop = false;
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить игру";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(129, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Загрузить игру";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tmrBomb
            // 
            this.tmrBomb.Interval = 1000;
            this.tmrBomb.Tick += new System.EventHandler(this.tmrBomb_Tick);
            // 
            // Labirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 544);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlLabir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Labirint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirint";
            this.Load += new System.EventHandler(this.Labirint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Labirint_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabir;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label lblSch;
        private System.Windows.Forms.Label lblwal;
        private System.Windows.Forms.Label lblBoom;
        private System.Windows.Forms.Label lblinv;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer tmrBomb;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnShop;
    }
}

