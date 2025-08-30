namespace STA
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
            step1Lb1 = new Label();
            keyWordsTxt = new TextBox();
            label2 = new Label();
            searchWebBtn = new Button();
            label1 = new Label();
            foundUrlsListBox = new ListBox();
            browseBtn = new Button();
            showFoundUrlsBtn = new Button();
            browserPnl = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            emptyLbl = new Label();
            label7 = new Label();
            extractBtn = new Button();
            removeUrlBtn = new Button();
            saveCosmosBtn = new Button();
            indexBtn = new Button();
            semanticSrchBtn = new Button();
            SuspendLayout();
            // 
            // step1Lb1
            // 
            step1Lb1.AutoSize = true;
            step1Lb1.Location = new Point(96, 80);
            step1Lb1.Name = "step1Lb1";
            step1Lb1.Size = new Size(841, 54);
            step1Lb1.TabIndex = 0;
            step1Lb1.Text = "(1) Search web for sites related to your project";
            // 
            // keyWordsTxt
            // 
            keyWordsTxt.Location = new Point(163, 237);
            keyWordsTxt.Multiline = true;
            keyWordsTxt.Name = "keyWordsTxt";
            keyWordsTxt.Size = new Size(1175, 317);
            keyWordsTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 162);
            label2.Name = "label2";
            label2.Size = new Size(1301, 54);
            label2.TabIndex = 2;
            label2.Text = "Enter key words line by line.  Key word lines will be combined with \"OR\".";
            // 
            // searchWebBtn
            // 
            searchWebBtn.Location = new Point(1357, 460);
            searchWebBtn.Name = "searchWebBtn";
            searchWebBtn.Size = new Size(257, 94);
            searchWebBtn.TabIndex = 3;
            searchWebBtn.Text = "Search";
            searchWebBtn.UseVisualStyleBackColor = true;
            searchWebBtn.Click += searchWebBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 648);
            label1.Name = "label1";
            label1.Size = new Size(684, 54);
            label1.TabIndex = 4;
            label1.Text = "(2) Show URLs from the recent search";
            // 
            // foundUrlsListBox
            // 
            foundUrlsListBox.FormattingEnabled = true;
            foundUrlsListBox.HorizontalScrollbar = true;
            foundUrlsListBox.Location = new Point(163, 729);
            foundUrlsListBox.Name = "foundUrlsListBox";
            foundUrlsListBox.ScrollAlwaysVisible = true;
            foundUrlsListBox.Size = new Size(1162, 544);
            foundUrlsListBox.TabIndex = 5;
            // 
            // browseBtn
            // 
            browseBtn.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseBtn.Location = new Point(1357, 807);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(257, 94);
            browseBtn.TabIndex = 6;
            browseBtn.Text = ">";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // showFoundUrlsBtn
            // 
            showFoundUrlsBtn.Location = new Point(817, 644);
            showFoundUrlsBtn.Name = "showFoundUrlsBtn";
            showFoundUrlsBtn.Size = new Size(183, 75);
            showFoundUrlsBtn.TabIndex = 7;
            showFoundUrlsBtn.Text = "Show";
            showFoundUrlsBtn.UseVisualStyleBackColor = true;
            showFoundUrlsBtn.Click += showFoundUrlsBtn_Click;
            // 
            // browserPnl
            // 
            browserPnl.Location = new Point(1648, 729);
            browserPnl.Name = "browserPnl";
            browserPnl.Size = new Size(800, 544);
            browserPnl.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 1389);
            label3.Name = "label3";
            label3.Size = new Size(659, 54);
            label3.TabIndex = 9;
            label3.Text = "(3) Extract web page or PDF content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 1700);
            label4.Name = "label4";
            label4.Size = new Size(743, 54);
            label4.TabIndex = 10;
            label4.Text = "(4) Save extracted content to Cosmos DB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 2000);
            label5.Name = "label5";
            label5.Size = new Size(496, 54);
            label5.TabIndex = 11;
            label5.Text = "(5) Index Cosmos DB items";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 2400);
            label6.Name = "label6";
            label6.Size = new Size(522, 54);
            label6.TabIndex = 12;
            label6.Text = "(6) Hybrid / Semantic search";
            // 
            // emptyLbl
            // 
            emptyLbl.AutoSize = true;
            emptyLbl.Location = new Point(96, 3000);
            emptyLbl.Name = "emptyLbl";
            emptyLbl.Size = new Size(363, 54);
            emptyLbl.TabIndex = 13;
            emptyLbl.Text = "____________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 2785);
            label7.Name = "label7";
            label7.Size = new Size(959, 54);
            label7.TabIndex = 14;
            label7.Text = "(7) Compare search results with company benchmark";
            // 
            // extractBtn
            // 
            extractBtn.Location = new Point(163, 1462);
            extractBtn.Name = "extractBtn";
            extractBtn.Size = new Size(346, 94);
            extractBtn.TabIndex = 15;
            extractBtn.Text = "Extract";
            extractBtn.UseVisualStyleBackColor = true;
            // 
            // removeUrlBtn
            // 
            removeUrlBtn.Location = new Point(1357, 1110);
            removeUrlBtn.Name = "removeUrlBtn";
            removeUrlBtn.Size = new Size(257, 94);
            removeUrlBtn.TabIndex = 17;
            removeUrlBtn.Text = "Remove";
            removeUrlBtn.UseVisualStyleBackColor = true;
            // 
            // saveCosmosBtn
            // 
            saveCosmosBtn.Location = new Point(163, 1786);
            saveCosmosBtn.Name = "saveCosmosBtn";
            saveCosmosBtn.Size = new Size(346, 94);
            saveCosmosBtn.TabIndex = 18;
            saveCosmosBtn.Text = "Save to Cosmos";
            saveCosmosBtn.UseVisualStyleBackColor = true;
            // 
            // indexBtn
            // 
            indexBtn.Location = new Point(163, 2088);
            indexBtn.Name = "indexBtn";
            indexBtn.Size = new Size(346, 94);
            indexBtn.TabIndex = 19;
            indexBtn.Text = "Index";
            indexBtn.UseVisualStyleBackColor = true;
            // 
            // semanticSrchBtn
            // 
            semanticSrchBtn.Location = new Point(163, 2487);
            semanticSrchBtn.Name = "semanticSrchBtn";
            semanticSrchBtn.Size = new Size(346, 94);
            semanticSrchBtn.TabIndex = 20;
            semanticSrchBtn.Text = "Search";
            semanticSrchBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(2429, 1376);
            Controls.Add(semanticSrchBtn);
            Controls.Add(indexBtn);
            Controls.Add(saveCosmosBtn);
            Controls.Add(removeUrlBtn);
            Controls.Add(extractBtn);
            Controls.Add(label7);
            Controls.Add(emptyLbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(browserPnl);
            Controls.Add(showFoundUrlsBtn);
            Controls.Add(browseBtn);
            Controls.Add(foundUrlsListBox);
            Controls.Add(label1);
            Controls.Add(searchWebBtn);
            Controls.Add(label2);
            Controls.Add(keyWordsTxt);
            Controls.Add(step1Lb1);
            Name = "Form1";
            Text = "   ✰ ✰ ✰ STA ✰ ✰ ✰";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label step1Lb1;
        private TextBox keyWordsTxt;
        private Label label2;
        private Button searchWebBtn;
        private Label label1;
        private ListBox foundUrlsListBox;
        private Button browseBtn;
        private Button showFoundUrlsBtn;
        private Panel browserPnl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label emptyLbl;
        private Label label7;
        private Button extractBtn;
        private Button removeUrlBtn;
        private Button saveCosmosBtn;
        private Button indexBtn;
        private Button semanticSrchBtn;
    }
}
