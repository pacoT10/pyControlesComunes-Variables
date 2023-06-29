namespace pyControlesComunes_Variables
{
    partial class frmRegistrarTarea
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
            this.cboHuerfano = new System.Windows.Forms.ComboBox();
            this.cboTareas = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.gbReunion = new System.Windows.Forms.GroupBox();
            this.optNO = new System.Windows.Forms.RadioButton();
            this.optSI = new System.Windows.Forms.RadioButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkrepositorio = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.gbReunion.SuspendLayout();
            this.gbTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboHuerfano
            // 
            this.cboHuerfano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuerfano.FormattingEnabled = true;
            this.cboHuerfano.Items.AddRange(new object[] {
            "Tarea 11",
            "Tarea 12",
            "Tarea 13",
            "Tarea 14",
            "Tarea 15"});
            this.cboHuerfano.Location = new System.Drawing.Point(488, 312);
            this.cboHuerfano.Margin = new System.Windows.Forms.Padding(2);
            this.cboHuerfano.Name = "cboHuerfano";
            this.cboHuerfano.Size = new System.Drawing.Size(92, 21);
            this.cboHuerfano.TabIndex = 0;
            // 
            // cboTareas
            // 
            this.cboTareas.FormattingEnabled = true;
            this.cboTareas.Location = new System.Drawing.Point(488, 336);
            this.cboTareas.Margin = new System.Windows.Forms.Padding(2);
            this.cboTareas.Name = "cboTareas";
            this.cboTareas.Size = new System.Drawing.Size(92, 21);
            this.cboTareas.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 14);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(18, 60);
            this.lblTipoActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(28, 13);
            this.lblTipoActividad.TabIndex = 3;
            this.lblTipoActividad.Text = "Tipo";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(20, 109);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(18, 29);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(206, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Items.AddRange(new object[] {
            "Tarea 11",
            "Tarea 12",
            "Tarea 13",
            "Tarea 14",
            "Tarea 15"});
            this.cboTipoActividad.Location = new System.Drawing.Point(18, 76);
            this.cboTipoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(206, 21);
            this.cboTipoActividad.TabIndex = 6;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(20, 124);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(206, 88);
            this.txtDetalle.TabIndex = 7;
            // 
            // gbReunion
            // 
            this.gbReunion.Controls.Add(this.optNO);
            this.gbReunion.Controls.Add(this.optSI);
            this.gbReunion.Location = new System.Drawing.Point(22, 228);
            this.gbReunion.Margin = new System.Windows.Forms.Padding(2);
            this.gbReunion.Name = "gbReunion";
            this.gbReunion.Padding = new System.Windows.Forms.Padding(2);
            this.gbReunion.Size = new System.Drawing.Size(202, 44);
            this.gbReunion.TabIndex = 8;
            this.gbReunion.TabStop = false;
            this.gbReunion.Text = "Reunión";
            // 
            // optNO
            // 
            this.optNO.AutoSize = true;
            this.optNO.Location = new System.Drawing.Point(112, 17);
            this.optNO.Margin = new System.Windows.Forms.Padding(2);
            this.optNO.Name = "optNO";
            this.optNO.Size = new System.Drawing.Size(41, 17);
            this.optNO.TabIndex = 1;
            this.optNO.Text = "NO";
            this.optNO.UseVisualStyleBackColor = true;
            // 
            // optSI
            // 
            this.optSI.AutoSize = true;
            this.optSI.Checked = true;
            this.optSI.Location = new System.Drawing.Point(39, 17);
            this.optSI.Margin = new System.Windows.Forms.Padding(2);
            this.optSI.Name = "optSI";
            this.optSI.Size = new System.Drawing.Size(35, 17);
            this.optSI.TabIndex = 0;
            this.optSI.TabStop = true;
            this.optSI.Text = "SI";
            this.optSI.UseVisualStyleBackColor = true;
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.chkNotasReunion);
            this.gbTareas.Controls.Add(this.chkDebate);
            this.gbTareas.Controls.Add(this.chkInvestigacion);
            this.gbTareas.Controls.Add(this.chkrepositorio);
            this.gbTareas.Location = new System.Drawing.Point(22, 277);
            this.gbTareas.Margin = new System.Windows.Forms.Padding(2);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Padding = new System.Windows.Forms.Padding(2);
            this.gbTareas.Size = new System.Drawing.Size(202, 72);
            this.gbTareas.TabIndex = 9;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Tareas";
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(96, 41);
            this.chkNotasReunion.Margin = new System.Windows.Forms.Padding(2);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 3;
            this.chkNotasReunion.Text = "Notas Reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(96, 24);
            this.chkDebate.Margin = new System.Windows.Forms.Padding(2);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 2;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(4, 40);
            this.chkInvestigacion.Margin = new System.Windows.Forms.Padding(2);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkrepositorio
            // 
            this.chkrepositorio.AutoSize = true;
            this.chkrepositorio.Location = new System.Drawing.Point(4, 24);
            this.chkrepositorio.Margin = new System.Windows.Forms.Padding(2);
            this.chkrepositorio.Name = "chkrepositorio";
            this.chkrepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkrepositorio.TabIndex = 0;
            this.chkrepositorio.Text = "Repositorio";
            this.chkrepositorio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 360);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 19);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(84, 360);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(73, 19);
            this.cmdGrabar.TabIndex = 11;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(161, 360);
            this.cmdMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(65, 19);
            this.cmdMostrar.TabIndex = 18;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 390);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbTareas);
            this.Controls.Add(this.gbReunion);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboTareas);
            this.Controls.Add(this.cboHuerfano);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Actividad";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            this.gbReunion.ResumeLayout(false);
            this.gbReunion.PerformLayout();
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHuerfano;
        private System.Windows.Forms.ComboBox cboTareas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox gbReunion;
        private System.Windows.Forms.RadioButton optNO;
        private System.Windows.Forms.RadioButton optSI;
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkrepositorio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdMostrar;
    }
}