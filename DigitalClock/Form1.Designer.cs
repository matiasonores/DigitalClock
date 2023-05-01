
namespace DigitalClock
{
   partial class DigitalClock
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
         this.components = new System.ComponentModel.Container();
         this.clockLabel = new System.Windows.Forms.Label();
         this.clockTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // clockLabel
         // 
         this.clockLabel.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.clockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
         this.clockLabel.Location = new System.Drawing.Point(12, 9);
         this.clockLabel.Name = "clockLabel";
         this.clockLabel.Size = new System.Drawing.Size(776, 432);
         this.clockLabel.TabIndex = 0;
         this.clockLabel.Text = "Loading...";
         this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // clockTimer
         // 
         this.clockTimer.Interval = 1000;
         this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
         // 
         // DigitalClock
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.clockLabel);
         this.Name = "DigitalClock";
         this.Text = "Digital Clock";
         this.Load += new System.EventHandler(this.DigitalClock_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label clockLabel;
      private System.Windows.Forms.Timer clockTimer;
   }
}

