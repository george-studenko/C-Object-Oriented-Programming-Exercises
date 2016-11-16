namespace _70_483
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.InheritanceButton = new System.Windows.Forms.Button();
            this.testStructsButton = new System.Windows.Forms.Button();
            this.delegatesButton = new System.Windows.Forms.Button();
            this.TestEventHandlerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(12, 12);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(98, 23);
            this.createEmployeeButton.TabIndex = 0;
            this.createEmployeeButton.Text = "Create Employee";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // InheritanceButton
            // 
            this.InheritanceButton.Location = new System.Drawing.Point(116, 12);
            this.InheritanceButton.Name = "InheritanceButton";
            this.InheritanceButton.Size = new System.Drawing.Size(126, 23);
            this.InheritanceButton.TabIndex = 1;
            this.InheritanceButton.Text = "Test Inheritance";
            this.InheritanceButton.UseVisualStyleBackColor = true;
            this.InheritanceButton.Click += new System.EventHandler(this.inheritanceButton_Click);
            // 
            // testStructsButton
            // 
            this.testStructsButton.Location = new System.Drawing.Point(13, 42);
            this.testStructsButton.Name = "testStructsButton";
            this.testStructsButton.Size = new System.Drawing.Size(229, 23);
            this.testStructsButton.TabIndex = 2;
            this.testStructsButton.Text = "Test Structs";
            this.testStructsButton.UseVisualStyleBackColor = true;
            this.testStructsButton.Click += new System.EventHandler(this.testStructsButton_Click);
            // 
            // delegatesButton
            // 
            this.delegatesButton.Location = new System.Drawing.Point(12, 71);
            this.delegatesButton.Name = "delegatesButton";
            this.delegatesButton.Size = new System.Drawing.Size(230, 23);
            this.delegatesButton.TabIndex = 3;
            this.delegatesButton.Text = "Test Delegates";
            this.delegatesButton.UseVisualStyleBackColor = true;
            this.delegatesButton.Click += new System.EventHandler(this.delegatesButton_Click);
            // 
            // TestEventHandlerButton
            // 
            this.TestEventHandlerButton.Location = new System.Drawing.Point(13, 101);
            this.TestEventHandlerButton.Name = "TestEventHandlerButton";
            this.TestEventHandlerButton.Size = new System.Drawing.Size(229, 23);
            this.TestEventHandlerButton.TabIndex = 4;
            this.TestEventHandlerButton.Text = "Test EventHandlers";
            this.TestEventHandlerButton.UseVisualStyleBackColor = true;
            this.TestEventHandlerButton.Click += new System.EventHandler(this.TestEventHandlerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 261);
            this.Controls.Add(this.TestEventHandlerButton);
            this.Controls.Add(this.delegatesButton);
            this.Controls.Add(this.testStructsButton);
            this.Controls.Add(this.InheritanceButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Name = "Form1";
            this.Text = "Exam 70-483 Tests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button InheritanceButton;
        private System.Windows.Forms.Button testStructsButton;
        private System.Windows.Forms.Button delegatesButton;
        private System.Windows.Forms.Button TestEventHandlerButton;
    }
}

