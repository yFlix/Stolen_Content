namespace Stolen_Content
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.txtBox = new System.Windows.Forms.TextBox();
            this.bntStolen = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.bntStop = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtConsoleTitulo = new System.Windows.Forms.Label();
            this.cbGrupoEnviar = new System.Windows.Forms.ComboBox();
            this.cbNomeGrupo = new System.Windows.Forms.ComboBox();
            this.bntNomeGrupoSalvar = new System.Windows.Forms.Button();
            this.bntNomeGrupoApagar = new System.Windows.Forms.Button();
            this.bntGrupoEnviarApagar = new System.Windows.Forms.Button();
            this.bntGrupoEnviarSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtBoxWhatsapp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTelegram = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLinhas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTextoSub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxEmote = new System.Windows.Forms.TextBox();
            this.bntApagarSub = new System.Windows.Forms.Button();
            this.bntSalvarSub = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgEmote = new System.Windows.Forms.DataGridView();
            this.Emote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Substituição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChatGPT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmote)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(323, 78);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(344, 212);
            this.txtBox.TabIndex = 0;
            // 
            // bntStolen
            // 
            this.bntStolen.BackColor = System.Drawing.SystemColors.Control;
            this.bntStolen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntStolen.FlatAppearance.BorderSize = 0;
            this.bntStolen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntStolen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntStolen.Location = new System.Drawing.Point(242, 548);
            this.bntStolen.Name = "bntStolen";
            this.bntStolen.Size = new System.Drawing.Size(75, 30);
            this.bntStolen.TabIndex = 2;
            this.bntStolen.Text = "Iniciar";
            this.bntStolen.UseVisualStyleBackColor = false;
            this.bntStolen.Click += new System.EventHandler(this.bntStolen_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(676, 77);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ReadOnly = true;
            this.txtBox2.Size = new System.Drawing.Size(341, 212);
            this.txtBox2.TabIndex = 3;
            // 
            // bntStop
            // 
            this.bntStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntStop.Enabled = false;
            this.bntStop.FlatAppearance.BorderSize = 0;
            this.bntStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntStop.Location = new System.Drawing.Point(242, 582);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(75, 30);
            this.bntStop.TabIndex = 4;
            this.bntStop.Text = "Parar";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(24, 51);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(293, 478);
            this.txtConsole.TabIndex = 6;
            // 
            // txtConsoleTitulo
            // 
            this.txtConsoleTitulo.AutoSize = true;
            this.txtConsoleTitulo.Location = new System.Drawing.Point(24, 35);
            this.txtConsoleTitulo.Name = "txtConsoleTitulo";
            this.txtConsoleTitulo.Size = new System.Drawing.Size(93, 13);
            this.txtConsoleTitulo.TabIndex = 7;
            this.txtConsoleTitulo.Text = "Console (Eventos)";
            // 
            // cbGrupoEnviar
            // 
            this.cbGrupoEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.cbGrupoEnviar.FormattingEnabled = true;
            this.cbGrupoEnviar.Items.AddRange(new object[] {
            "Grupo de Teste: A",
            "Grupo de Teste: B"});
            this.cbGrupoEnviar.Location = new System.Drawing.Point(833, 50);
            this.cbGrupoEnviar.Name = "cbGrupoEnviar";
            this.cbGrupoEnviar.Size = new System.Drawing.Size(141, 21);
            this.cbGrupoEnviar.TabIndex = 9;
            // 
            // cbNomeGrupo
            // 
            this.cbNomeGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.cbNomeGrupo.FormattingEnabled = true;
            this.cbNomeGrupo.Items.AddRange(new object[] {
            "Grupo de Teste: A"});
            this.cbNomeGrupo.Location = new System.Drawing.Point(323, 51);
            this.cbNomeGrupo.Name = "cbNomeGrupo";
            this.cbNomeGrupo.Size = new System.Drawing.Size(141, 21);
            this.cbNomeGrupo.TabIndex = 10;
            // 
            // bntNomeGrupoSalvar
            // 
            this.bntNomeGrupoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNomeGrupoSalvar.FlatAppearance.BorderSize = 0;
            this.bntNomeGrupoSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntNomeGrupoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntNomeGrupoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNomeGrupoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("bntNomeGrupoSalvar.Image")));
            this.bntNomeGrupoSalvar.Location = new System.Drawing.Point(489, 48);
            this.bntNomeGrupoSalvar.Name = "bntNomeGrupoSalvar";
            this.bntNomeGrupoSalvar.Size = new System.Drawing.Size(24, 24);
            this.bntNomeGrupoSalvar.TabIndex = 12;
            this.bntNomeGrupoSalvar.UseVisualStyleBackColor = true;
            this.bntNomeGrupoSalvar.Click += new System.EventHandler(this.bntNomeGrupoSalvar_Click);
            // 
            // bntNomeGrupoApagar
            // 
            this.bntNomeGrupoApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNomeGrupoApagar.FlatAppearance.BorderSize = 0;
            this.bntNomeGrupoApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntNomeGrupoApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntNomeGrupoApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNomeGrupoApagar.Image = ((System.Drawing.Image)(resources.GetObject("bntNomeGrupoApagar.Image")));
            this.bntNomeGrupoApagar.Location = new System.Drawing.Point(467, 48);
            this.bntNomeGrupoApagar.Name = "bntNomeGrupoApagar";
            this.bntNomeGrupoApagar.Size = new System.Drawing.Size(24, 24);
            this.bntNomeGrupoApagar.TabIndex = 14;
            this.bntNomeGrupoApagar.UseVisualStyleBackColor = true;
            this.bntNomeGrupoApagar.Click += new System.EventHandler(this.bntNomeGrupoApagar_Click);
            // 
            // bntGrupoEnviarApagar
            // 
            this.bntGrupoEnviarApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGrupoEnviarApagar.FlatAppearance.BorderSize = 0;
            this.bntGrupoEnviarApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntGrupoEnviarApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntGrupoEnviarApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGrupoEnviarApagar.Image = ((System.Drawing.Image)(resources.GetObject("bntGrupoEnviarApagar.Image")));
            this.bntGrupoEnviarApagar.Location = new System.Drawing.Point(976, 47);
            this.bntGrupoEnviarApagar.Name = "bntGrupoEnviarApagar";
            this.bntGrupoEnviarApagar.Size = new System.Drawing.Size(24, 24);
            this.bntGrupoEnviarApagar.TabIndex = 16;
            this.bntGrupoEnviarApagar.UseVisualStyleBackColor = true;
            this.bntGrupoEnviarApagar.Click += new System.EventHandler(this.bntGrupoEnviarApagar_Click);
            // 
            // bntGrupoEnviarSalvar
            // 
            this.bntGrupoEnviarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGrupoEnviarSalvar.FlatAppearance.BorderSize = 0;
            this.bntGrupoEnviarSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntGrupoEnviarSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntGrupoEnviarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGrupoEnviarSalvar.Image = ((System.Drawing.Image)(resources.GetObject("bntGrupoEnviarSalvar.Image")));
            this.bntGrupoEnviarSalvar.Location = new System.Drawing.Point(998, 47);
            this.bntGrupoEnviarSalvar.Name = "bntGrupoEnviarSalvar";
            this.bntGrupoEnviarSalvar.Size = new System.Drawing.Size(24, 24);
            this.bntGrupoEnviarSalvar.TabIndex = 15;
            this.bntGrupoEnviarSalvar.UseVisualStyleBackColor = true;
            this.bntGrupoEnviarSalvar.Click += new System.EventHandler(this.bntSalvarGrupo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Grupo Alvo (Selecione)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seu Grupo (Todos da Lista)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Perfil 01 (Selecione)";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(182, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(204, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 548);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Perfil 02 (Selecione)";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(182, 589);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(204, 589);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 591);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(123, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 10);
            this.progressBar1.TabIndex = 30;
            // 
            // txtBoxWhatsapp
            // 
            this.txtBoxWhatsapp.Location = new System.Drawing.Point(323, 548);
            this.txtBoxWhatsapp.Multiline = true;
            this.txtBoxWhatsapp.Name = "txtBoxWhatsapp";
            this.txtBoxWhatsapp.Size = new System.Drawing.Size(344, 21);
            this.txtBoxWhatsapp.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Substituir link do Whatsapp por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Substituir link do Telegram por:";
            // 
            // txtBoxTelegram
            // 
            this.txtBoxTelegram.Location = new System.Drawing.Point(323, 590);
            this.txtBoxTelegram.Multiline = true;
            this.txtBoxTelegram.Name = "txtBoxTelegram";
            this.txtBoxTelegram.Size = new System.Drawing.Size(344, 21);
            this.txtBoxTelegram.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(745, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Linhas";
            // 
            // cbLinhas
            // 
            this.cbLinhas.BackColor = System.Drawing.SystemColors.Control;
            this.cbLinhas.FormattingEnabled = true;
            this.cbLinhas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cbLinhas.Location = new System.Drawing.Point(748, 50);
            this.cbLinhas.Name = "cbLinhas";
            this.cbLinhas.Size = new System.Drawing.Size(79, 21);
            this.cbLinhas.TabIndex = 36;
            this.cbLinhas.Text = "0";
            this.cbLinhas.SelectedIndexChanged += new System.EventHandler(this.cbLinhas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Substituição";
            // 
            // txtBoxTextoSub
            // 
            this.txtBoxTextoSub.Location = new System.Drawing.Point(455, 307);
            this.txtBoxTextoSub.Multiline = true;
            this.txtBoxTextoSub.Name = "txtBoxTextoSub";
            this.txtBoxTextoSub.Size = new System.Drawing.Size(164, 21);
            this.txtBoxTextoSub.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Texto";
            // 
            // txtBoxEmote
            // 
            this.txtBoxEmote.Location = new System.Drawing.Point(323, 307);
            this.txtBoxEmote.Multiline = true;
            this.txtBoxEmote.Name = "txtBoxEmote";
            this.txtBoxEmote.Size = new System.Drawing.Size(126, 21);
            this.txtBoxEmote.TabIndex = 40;
            // 
            // bntApagarSub
            // 
            this.bntApagarSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntApagarSub.FlatAppearance.BorderSize = 0;
            this.bntApagarSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntApagarSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntApagarSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntApagarSub.Image = ((System.Drawing.Image)(resources.GetObject("bntApagarSub.Image")));
            this.bntApagarSub.Location = new System.Drawing.Point(624, 304);
            this.bntApagarSub.Name = "bntApagarSub";
            this.bntApagarSub.Size = new System.Drawing.Size(24, 24);
            this.bntApagarSub.TabIndex = 44;
            this.bntApagarSub.UseVisualStyleBackColor = true;
            this.bntApagarSub.Click += new System.EventHandler(this.bntApagarSub_Click);
            // 
            // bntSalvarSub
            // 
            this.bntSalvarSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvarSub.FlatAppearance.BorderSize = 0;
            this.bntSalvarSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntSalvarSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntSalvarSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvarSub.Image = ((System.Drawing.Image)(resources.GetObject("bntSalvarSub.Image")));
            this.bntSalvarSub.Location = new System.Drawing.Point(646, 304);
            this.bntSalvarSub.Name = "bntSalvarSub";
            this.bntSalvarSub.Size = new System.Drawing.Size(24, 24);
            this.bntSalvarSub.TabIndex = 43;
            this.bntSalvarSub.UseVisualStyleBackColor = true;
            this.bntSalvarSub.Click += new System.EventHandler(this.bntSalvarSub_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Prompt do ChatGPT";
            // 
            // dgEmote
            // 
            this.dgEmote.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgEmote.AllowUserToAddRows = false;
            this.dgEmote.AllowUserToDeleteRows = false;
            this.dgEmote.AllowUserToResizeColumns = false;
            this.dgEmote.AllowUserToResizeRows = false;
            this.dgEmote.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgEmote.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgEmote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgEmote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEmote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emote,
            this.Substituição});
            this.dgEmote.Location = new System.Drawing.Point(323, 334);
            this.dgEmote.MultiSelect = false;
            this.dgEmote.Name = "dgEmote";
            this.dgEmote.RowHeadersVisible = false;
            this.dgEmote.ShowCellErrors = false;
            this.dgEmote.ShowCellToolTips = false;
            this.dgEmote.ShowEditingIcon = false;
            this.dgEmote.ShowRowErrors = false;
            this.dgEmote.Size = new System.Drawing.Size(344, 195);
            this.dgEmote.TabIndex = 48;
            this.dgEmote.TabStop = false;
            // 
            // Emote
            // 
            this.Emote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Emote.FillWeight = 50F;
            this.Emote.HeaderText = "Texto";
            this.Emote.Name = "Emote";
            // 
            // Substituição
            // 
            this.Substituição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Substituição.HeaderText = "Substituição";
            this.Substituição.Name = "Substituição";
            // 
            // txtChatGPT
            // 
            this.txtChatGPT.BackColor = System.Drawing.SystemColors.Control;
            this.txtChatGPT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChatGPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatGPT.Location = new System.Drawing.Point(676, 308);
            this.txtChatGPT.Multiline = true;
            this.txtChatGPT.Name = "txtChatGPT";
            this.txtChatGPT.Size = new System.Drawing.Size(341, 304);
            this.txtChatGPT.TabIndex = 49;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 646);
            this.Controls.Add(this.txtChatGPT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bntApagarSub);
            this.Controls.Add(this.bntSalvarSub);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxEmote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxTextoSub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLinhas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxTelegram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxWhatsapp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntGrupoEnviarApagar);
            this.Controls.Add(this.bntGrupoEnviarSalvar);
            this.Controls.Add(this.bntNomeGrupoApagar);
            this.Controls.Add(this.bntNomeGrupoSalvar);
            this.Controls.Add(this.cbNomeGrupo);
            this.Controls.Add(this.cbGrupoEnviar);
            this.Controls.Add(this.txtConsoleTitulo);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.bntStolen);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.dgEmote);
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.Text = "Stolen Content Bot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntStolen;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Label txtConsoleTitulo;
        public System.Windows.Forms.TextBox txtBox;
        public System.Windows.Forms.TextBox txtBox2;
        public System.Windows.Forms.TextBox txtConsole;
        public System.Windows.Forms.ComboBox cbNomeGrupo;
        public System.Windows.Forms.ComboBox cbGrupoEnviar;
        private System.Windows.Forms.Button bntNomeGrupoSalvar;
        private System.Windows.Forms.Button bntNomeGrupoApagar;
        private System.Windows.Forms.Button bntGrupoEnviarApagar;
        private System.Windows.Forms.Button bntGrupoEnviarSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtBoxWhatsapp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTelegram;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbLinhas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTextoSub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxEmote;
        private System.Windows.Forms.Button bntApagarSub;
        private System.Windows.Forms.Button bntSalvarSub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgEmote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Substituição;
        public System.Windows.Forms.TextBox txtChatGPT;
    }
}

