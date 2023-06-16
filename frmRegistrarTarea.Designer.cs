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
            this.optSI = new System.Windows.Forms.RadioButton();
            this.optNO = new System.Windows.Forms.RadioButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.chkrepositorio = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdVerVector = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCargarVector = new System.Windows.Forms.Button();
            this.btnVerVector2 = new System.Windows.Forms.Button();
            this.btnVerVector3 = new System.Windows.Forms.Button();
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
            this.cboHuerfano.Location = new System.Drawing.Point(651, 384);
            this.cboHuerfano.Name = "cboHuerfano";
            this.cboHuerfano.Size = new System.Drawing.Size(121, 24);
            this.cboHuerfano.TabIndex = 0;
            // 
            // cboTareas
            // 
            this.cboTareas.FormattingEnabled = true;
            this.cboTareas.Location = new System.Drawing.Point(651, 414);
            this.cboTareas.Name = "cboTareas";
            this.cboTareas.Size = new System.Drawing.Size(121, 24);
            this.cboTareas.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 17);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(24, 74);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(35, 16);
            this.lblTipoActividad.TabIndex = 3;
            this.lblTipoActividad.Text = "Tipo";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(27, 134);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(50, 16);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(24, 36);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(273, 22);
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
            this.cboTipoActividad.Location = new System.Drawing.Point(24, 93);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(273, 24);
            this.cboTipoActividad.TabIndex = 6;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(27, 153);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(273, 108);
            this.txtDetalle.TabIndex = 7;
            // 
            // gbReunion
            // 
            this.gbReunion.Controls.Add(this.optNO);
            this.gbReunion.Controls.Add(this.optSI);
            this.gbReunion.Location = new System.Drawing.Point(30, 281);
            this.gbReunion.Name = "gbReunion";
            this.gbReunion.Size = new System.Drawing.Size(270, 54);
            this.gbReunion.TabIndex = 8;
            this.gbReunion.TabStop = false;
            this.gbReunion.Text = "Reunión";
            // 
            // optSI
            // 
            this.optSI.AutoSize = true;
            this.optSI.Location = new System.Drawing.Point(52, 21);
            this.optSI.Name = "optSI";
            this.optSI.Size = new System.Drawing.Size(40, 20);
            this.optSI.TabIndex = 0;
            this.optSI.TabStop = true;
            this.optSI.Text = "SI";
            this.optSI.UseVisualStyleBackColor = true;
            // 
            // optNO
            // 
            this.optNO.AutoSize = true;
            this.optNO.Location = new System.Drawing.Point(149, 21);
            this.optNO.Name = "optNO";
            this.optNO.Size = new System.Drawing.Size(48, 20);
            this.optNO.TabIndex = 1;
            this.optNO.TabStop = true;
            this.optNO.Text = "NO";
            this.optNO.UseVisualStyleBackColor = true;
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.chkNotasReunion);
            this.gbTareas.Controls.Add(this.chkDebate);
            this.gbTareas.Controls.Add(this.chkInvestigacion);
            this.gbTareas.Controls.Add(this.chkrepositorio);
            this.gbTareas.Location = new System.Drawing.Point(30, 341);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Size = new System.Drawing.Size(270, 88);
            this.gbTareas.TabIndex = 9;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Tareas";
            // 
            // chkrepositorio
            // 
            this.chkrepositorio.AutoSize = true;
            this.chkrepositorio.Location = new System.Drawing.Point(6, 29);
            this.chkrepositorio.Name = "chkrepositorio";
            this.chkrepositorio.Size = new System.Drawing.Size(99, 20);
            this.chkrepositorio.TabIndex = 0;
            this.chkrepositorio.Text = "Repositorio";
            this.chkrepositorio.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(6, 49);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(108, 20);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(128, 29);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(74, 20);
            this.chkDebate.TabIndex = 2;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(128, 50);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(118, 20);
            this.chkNotasReunion.TabIndex = 3;
            this.chkNotasReunion.Text = "Notas Reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(144, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(225, 445);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdVerVector
            // 
            this.cmdVerVector.Location = new System.Drawing.Point(419, 74);
            this.cmdVerVector.Name = "cmdVerVector";
            this.cmdVerVector.Size = new System.Drawing.Size(179, 51);
            this.cmdVerVector.TabIndex = 13;
            this.cmdVerVector.Text = "Ver Vector";
            this.cmdVerVector.UseVisualStyleBackColor = true;
            this.cmdVerVector.Click += new System.EventHandler(this.cmdVerVector_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(419, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 212);
            this.listBox1.TabIndex = 14;
            // 
            // btnCargarVector
            // 
            this.btnCargarVector.Location = new System.Drawing.Point(419, 17);
            this.btnCargarVector.Name = "btnCargarVector";
            this.btnCargarVector.Size = new System.Drawing.Size(179, 51);
            this.btnCargarVector.TabIndex = 15;
            this.btnCargarVector.Text = "Cargar Vector";
            this.btnCargarVector.UseVisualStyleBackColor = true;
            this.btnCargarVector.Click += new System.EventHandler(this.btnCargarVector_Click);
            // 
            // btnVerVector2
            // 
            this.btnVerVector2.Location = new System.Drawing.Point(419, 131);
            this.btnVerVector2.Name = "btnVerVector2";
            this.btnVerVector2.Size = new System.Drawing.Size(179, 51);
            this.btnVerVector2.TabIndex = 16;
            this.btnVerVector2.Text = "Ver Vector prop Array";
            this.btnVerVector2.UseVisualStyleBackColor = true;
            this.btnVerVector2.Click += new System.EventHandler(this.btnVerVector2_Click);
            // 
            // btnVerVector3
            // 
            this.btnVerVector3.Location = new System.Drawing.Point(419, 188);
            this.btnVerVector3.Name = "btnVerVector3";
            this.btnVerVector3.Size = new System.Drawing.Size(179, 51);
            this.btnVerVector3.TabIndex = 17;
            this.btnVerVector3.Text = "Ver Vector For";
            this.btnVerVector3.UseVisualStyleBackColor = true;
            this.btnVerVector3.Click += new System.EventHandler(this.btnVerVector3_Click);
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 480);
            this.Controls.Add(this.btnVerVector3);
            this.Controls.Add(this.btnVerVector2);
            this.Controls.Add(this.btnCargarVector);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdVerVector);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrabar);
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
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdVerVector;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCargarVector;
        private System.Windows.Forms.Button btnVerVector2;
        private System.Windows.Forms.Button btnVerVector3;
    }
}