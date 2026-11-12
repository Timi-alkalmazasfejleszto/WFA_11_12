namespace WFA_11_12
{
    partial class Form1
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
            txtSzoveg = new TextBox();
            lbxLista = new ListBox();
            btnHozzaad = new Button();
            btnOsszestorlese = new Button();
            btnTorol = new Button();
            SuspendLayout();
            // 
            // txtSzoveg
            // 
            txtSzoveg.Location = new Point(12, 52);
            txtSzoveg.Name = "txtSzoveg";
            txtSzoveg.PlaceholderText = "Írd ide a listabox elemét:";
            txtSzoveg.ScrollBars = ScrollBars.Horizontal;
            txtSzoveg.Size = new Size(363, 23);
            txtSzoveg.TabIndex = 0;
            // 
            // lbxLista
            // 
            lbxLista.FormattingEnabled = true;
            lbxLista.Location = new Point(12, 107);
            lbxLista.Name = "lbxLista";
            lbxLista.ScrollAlwaysVisible = true;
            lbxLista.Size = new Size(211, 304);
            lbxLista.TabIndex = 1;
            // 
            // btnHozzaad
            // 
            btnHozzaad.Font = new Font("Segoe UI", 12F);
            btnHozzaad.Location = new Point(249, 107);
            btnHozzaad.Name = "btnHozzaad";
            btnHozzaad.Size = new Size(126, 53);
            btnHozzaad.TabIndex = 2;
            btnHozzaad.Text = "Hozzaad";
            btnHozzaad.UseVisualStyleBackColor = true;
            // 
            // btnOsszestorlese
            // 
            btnOsszestorlese.Font = new Font("Segoe UI", 12F);
            btnOsszestorlese.Location = new Point(249, 358);
            btnOsszestorlese.Name = "btnOsszestorlese";
            btnOsszestorlese.Size = new Size(126, 53);
            btnOsszestorlese.TabIndex = 3;
            btnOsszestorlese.Text = "Osszes torlese";
            btnOsszestorlese.UseVisualStyleBackColor = true;
            // 
            // btnTorol
            // 
            btnTorol.Font = new Font("Segoe UI", 12F);
            btnTorol.Location = new Point(249, 231);
            btnTorol.Name = "btnTorol";
            btnTorol.Size = new Size(126, 53);
            btnTorol.TabIndex = 4;
            btnTorol.Text = "Torles";
            btnTorol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 462);
            Controls.Add(btnTorol);
            Controls.Add(btnOsszestorlese);
            Controls.Add(btnHozzaad);
            Controls.Add(lbxLista);
            Controls.Add(txtSzoveg);
            Name = "Form1";
            Text = "Lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSzoveg;
        private ListBox lbxLista;
        private Button btnHozzaad;
        private Button btnOsszestorlese;
        private Button btnTorol;
    }
}
