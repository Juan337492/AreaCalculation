
namespace Area
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.calAreaBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.radiusName = new System.Windows.Forms.Label();
            this.widthName = new System.Windows.Forms.Label();
            this.areaName = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.circleRadio = new System.Windows.Forms.RadioButton();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.rectRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.title.Location = new System.Drawing.Point(325, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(89, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Area";
            // 
            // calAreaBtn
            // 
            this.calAreaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calAreaBtn.Location = new System.Drawing.Point(191, 350);
            this.calAreaBtn.Name = "calAreaBtn";
            this.calAreaBtn.Size = new System.Drawing.Size(110, 37);
            this.calAreaBtn.TabIndex = 1;
            this.calAreaBtn.Text = "Calc Area";
            this.calAreaBtn.UseVisualStyleBackColor = true;
            this.calAreaBtn.Click += new System.EventHandler(this.calAreaBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clearBtn.Location = new System.Drawing.Point(353, 349);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 37);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton.Location = new System.Drawing.Point(495, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // radiusName
            // 
            this.radiusName.AutoSize = true;
            this.radiusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radiusName.Location = new System.Drawing.Point(480, 126);
            this.radiusName.Name = "radiusName";
            this.radiusName.Size = new System.Drawing.Size(72, 25);
            this.radiusName.TabIndex = 4;
            this.radiusName.Text = "Radius";
            // 
            // widthName
            // 
            this.widthName.AutoSize = true;
            this.widthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.widthName.Location = new System.Drawing.Point(480, 178);
            this.widthName.Name = "widthName";
            this.widthName.Size = new System.Drawing.Size(63, 25);
            this.widthName.TabIndex = 5;
            this.widthName.Text = "Width";
            // 
            // areaName
            // 
            this.areaName.AutoSize = true;
            this.areaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.areaName.Location = new System.Drawing.Point(489, 233);
            this.areaName.Name = "areaName";
            this.areaName.Size = new System.Drawing.Size(54, 25);
            this.areaName.TabIndex = 6;
            this.areaName.Text = "Area";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(568, 126);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(568, 184);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 8;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(568, 239);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 9;
            // 
            // circleRadio
            // 
            this.circleRadio.AutoSize = true;
            this.circleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circleRadio.Location = new System.Drawing.Point(269, 242);
            this.circleRadio.Name = "circleRadio";
            this.circleRadio.Size = new System.Drawing.Size(66, 24);
            this.circleRadio.TabIndex = 10;
            this.circleRadio.TabStop = true;
            this.circleRadio.Text = "Circle";
            this.circleRadio.UseVisualStyleBackColor = true;
            this.circleRadio.CheckedChanged += new System.EventHandler(this.circleRadio_CheckedChanged);
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.squareRadio.Location = new System.Drawing.Point(269, 133);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(79, 24);
            this.squareRadio.TabIndex = 11;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            this.squareRadio.CheckedChanged += new System.EventHandler(this.squareRadio_CheckedChanged);
            // 
            // rectRadio
            // 
            this.rectRadio.AutoSize = true;
            this.rectRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rectRadio.Location = new System.Drawing.Point(269, 187);
            this.rectRadio.Name = "rectRadio";
            this.rectRadio.Size = new System.Drawing.Size(100, 24);
            this.rectRadio.TabIndex = 12;
            this.rectRadio.TabStop = true;
            this.rectRadio.Text = "Rectangle";
            this.rectRadio.UseVisualStyleBackColor = true;
            this.rectRadio.CheckedChanged += new System.EventHandler(this.rectRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rectRadio);
            this.Controls.Add(this.squareRadio);
            this.Controls.Add(this.circleRadio);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.areaName);
            this.Controls.Add(this.widthName);
            this.Controls.Add(this.radiusName);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calAreaBtn);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button calAreaBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label radiusName;
        private System.Windows.Forms.Label widthName;
        private System.Windows.Forms.Label areaName;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.RadioButton circleRadio;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.RadioButton rectRadio;
    }
}

