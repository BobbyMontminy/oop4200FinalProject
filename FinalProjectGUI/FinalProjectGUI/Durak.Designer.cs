
namespace FinalProjectGUI
{
    partial class frmDurak
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
        private void InitializeComponent()
        {
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.optClick = new System.Windows.Forms.RadioButton();
            this.optDrag = new System.Windows.Forms.RadioButton();
            this.pbDiscard = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlPlayer2.Location = new System.Drawing.Point(170, 40);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(529, 134);
            this.pnlPlayer2.TabIndex = 0;
            // 
            // pbDeck
            // 
            this.pbDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDeck.Location = new System.Drawing.Point(34, 75);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(65, 94);
            this.pbDeck.TabIndex = 1;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // lblCardCount
            // 
            this.lblCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardCount.Location = new System.Drawing.Point(105, 75);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(41, 28);
            this.lblCardCount.TabIndex = 2;
            this.lblCardCount.Text = "69";
            this.lblCardCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardCount.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMain.Location = new System.Drawing.Point(170, 180);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(529, 191);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlPlayer1.Location = new System.Drawing.Point(170, 377);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(529, 134);
            this.pnlPlayer1.TabIndex = 1;
            this.pnlPlayer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlPlayer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 238);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // optClick
            // 
            this.optClick.AutoSize = true;
            this.optClick.Checked = true;
            this.optClick.Location = new System.Drawing.Point(43, 180);
            this.optClick.Name = "optClick";
            this.optClick.Size = new System.Drawing.Size(58, 21);
            this.optClick.TabIndex = 4;
            this.optClick.TabStop = true;
            this.optClick.Text = "Clic&k";
            this.optClick.UseVisualStyleBackColor = true;
            this.optClick.CheckedChanged += new System.EventHandler(this.optClick_CheckedChanged);
            // 
            // optDrag
            // 
            this.optDrag.AutoSize = true;
            this.optDrag.Location = new System.Drawing.Point(43, 203);
            this.optDrag.Name = "optDrag";
            this.optDrag.Size = new System.Drawing.Size(60, 21);
            this.optDrag.TabIndex = 5;
            this.optDrag.Text = "&Drag";
            this.optDrag.UseVisualStyleBackColor = true;
            this.optDrag.CheckedChanged += new System.EventHandler(this.optClick_CheckedChanged);
            // 
            // pbDiscard
            // 
            this.pbDiscard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDiscard.Location = new System.Drawing.Point(758, 75);
            this.pbDiscard.Name = "pbDiscard";
            this.pbDiscard.Size = new System.Drawing.Size(65, 94);
            this.pbDiscard.TabIndex = 6;
            this.pbDiscard.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(758, 453);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(758, 393);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(65, 40);
            this.btnTake.TabIndex = 8;
            this.btnTake.Text = "&TAKE";
            this.btnTake.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(34, 453);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(65, 23);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "&SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // frmDurak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 570);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbDiscard);
            this.Controls.Add(this.optDrag);
            this.Controls.Add(this.optClick);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblCardCount);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.pnlPlayer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDurak";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.Label lblCardCount;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton optClick;
        private System.Windows.Forms.RadioButton optDrag;
        private System.Windows.Forms.PictureBox pbDiscard;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSort;
    }
}

