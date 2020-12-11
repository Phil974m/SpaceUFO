namespace SpaceUFO
{
    partial class SpaceUFO
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceUFO));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemieMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.ReplayButton = new System.Windows.Forms.Button();
            this.QUITTER = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.BeginButton = new System.Windows.Forms.Button();
            this.ExplosionBox = new System.Windows.Forms.PictureBox();
            this.EnemiesExplosionBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InvadersBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemiesExplosionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvadersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 5;
            this.MoveBgTimer.Tick += new System.EventHandler(this.Move_Bg_Timer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.ErrorImage = null;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(525, 894);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(76, 105);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemieMunitionTimer
            // 
            this.EnemieMunitionTimer.Enabled = true;
            this.EnemieMunitionTimer.Interval = 20;
            this.EnemieMunitionTimer.Tick += new System.EventHandler(this.EnemieMunitionTimer_Tick);
            // 
            // ReplayButton
            // 
            this.ReplayButton.BackColor = System.Drawing.Color.OliveDrab;
            this.ReplayButton.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(366, 357);
            this.ReplayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(424, 114);
            this.ReplayButton.TabIndex = 2;
            this.ReplayButton.Text = "REJOUER";
            this.ReplayButton.UseVisualStyleBackColor = false;
            this.ReplayButton.Visible = false;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // QUITTER
            // 
            this.QUITTER.BackColor = System.Drawing.Color.DarkRed;
            this.QUITTER.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUITTER.Location = new System.Drawing.Point(366, 480);
            this.QUITTER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QUITTER.Name = "QUITTER";
            this.QUITTER.Size = new System.Drawing.Size(424, 114);
            this.QUITTER.TabIndex = 3;
            this.QUITTER.Text = "QUITTER";
            this.QUITTER.UseVisualStyleBackColor = false;
            this.QUITTER.Visible = false;
            this.QUITTER.Click += new System.EventHandler(this.QUITTER_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.DarkOrange;
            this.label.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label.Location = new System.Drawing.Point(461, 7);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(145, 88);
            this.label.TabIndex = 4;
            this.label.Text = "EVENT";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.DarkGreen;
            this.labelScore.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelScore.Location = new System.Drawing.Point(18, 14);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(174, 88);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "SCORE : ";
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.BackColor = System.Drawing.Color.DarkGreen;
            this.levelText.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.levelText.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.levelText.Location = new System.Drawing.Point(819, 15);
            this.levelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(158, 88);
            this.levelText.TabIndex = 6;
            this.levelText.Text = "LEVEL :";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_score.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_score.Location = new System.Drawing.Point(201, 15);
            this.label_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(82, 88);
            this.label_score.TabIndex = 7;
            this.label_score.Text = "00";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_level.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_level.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_level.Location = new System.Drawing.Point(986, 17);
            this.label_level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(82, 88);
            this.label_level.TabIndex = 8;
            this.label_level.Text = "00";
            // 
            // BeginButton
            // 
            this.BeginButton.BackColor = System.Drawing.Color.OrangeRed;
            this.BeginButton.Font = new System.Drawing.Font("LA TRUITE A PAPA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginButton.Location = new System.Drawing.Point(366, 357);
            this.BeginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(424, 114);
            this.BeginButton.TabIndex = 9;
            this.BeginButton.Text = "COMMENCER";
            this.BeginButton.UseVisualStyleBackColor = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // ExplosionBox
            // 
            this.ExplosionBox.BackColor = System.Drawing.Color.Transparent;
            this.ExplosionBox.BackgroundImage = global::SpaceUFO.Properties.Resources.explosion;
            this.ExplosionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExplosionBox.Location = new System.Drawing.Point(800, 600);
            this.ExplosionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExplosionBox.Name = "ExplosionBox";
            this.ExplosionBox.Size = new System.Drawing.Size(238, 240);
            this.ExplosionBox.TabIndex = 10;
            this.ExplosionBox.TabStop = false;
            this.ExplosionBox.Visible = false;
            // 
            // EnemiesExplosionBox
            // 
            this.EnemiesExplosionBox.BackColor = System.Drawing.Color.Transparent;
            this.EnemiesExplosionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemiesExplosionBox.Image = global::SpaceUFO.Properties.Resources.explosion_enemies;
            this.EnemiesExplosionBox.Location = new System.Drawing.Point(968, 289);
            this.EnemiesExplosionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemiesExplosionBox.Name = "EnemiesExplosionBox";
            this.EnemiesExplosionBox.Size = new System.Drawing.Size(62, 72);
            this.EnemiesExplosionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemiesExplosionBox.TabIndex = 11;
            this.EnemiesExplosionBox.TabStop = false;
            this.EnemiesExplosionBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SpaceUFO.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 138);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // InvadersBox
            // 
            this.InvadersBox.BackColor = System.Drawing.Color.Transparent;
            this.InvadersBox.BackgroundImage = global::SpaceUFO.Properties.Resources.back;
            this.InvadersBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InvadersBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InvadersBox.Image = global::SpaceUFO.Properties.Resources.space;
            this.InvadersBox.Location = new System.Drawing.Point(321, 15);
            this.InvadersBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InvadersBox.Name = "InvadersBox";
            this.InvadersBox.Size = new System.Drawing.Size(92, 92);
            this.InvadersBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InvadersBox.TabIndex = 13;
            this.InvadersBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::SpaceUFO.Properties.Resources.explode_png;
            this.pictureBox2.Location = new System.Drawing.Point(64, 249);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 95);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::SpaceUFO.Properties.Resources.asteroid_anim;
            this.pictureBox3.Location = new System.Drawing.Point(216, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 280);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // SpaceUFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceUFO.Properties.Resources.Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 994);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.QUITTER);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.ExplosionBox);
            this.Controls.Add(this.InvadersBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EnemiesExplosionBox);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SpaceUFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space UFO 0.1b";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceUFO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceUFO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemiesExplosionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvadersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemieMunitionTimer;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button QUITTER;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.PictureBox ExplosionBox;
        private System.Windows.Forms.PictureBox EnemiesExplosionBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox InvadersBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

