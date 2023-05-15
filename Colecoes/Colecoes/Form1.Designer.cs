namespace Colecoes
{
    partial class Colecoes
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
            this.lista = new System.Windows.Forms.ListBox();
            this.button_List = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_HashSet = new System.Windows.Forms.Button();
            this.button_Dictionary = new System.Windows.Forms.Button();
            this.button_SortedList = new System.Windows.Forms.Button();
            this.button_SortedDictionary = new System.Windows.Forms.Button();
            this.button_SortedSet = new System.Windows.Forms.Button();
            this.button_Queue = new System.Windows.Forms.Button();
            this.button_Stack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(0, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(585, 411);
            this.lista.TabIndex = 0;
            // 
            // button_List
            // 
            this.button_List.Location = new System.Drawing.Point(591, 12);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(181, 35);
            this.button_List.TabIndex = 1;
            this.button_List.Text = "List";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(690, 370);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(82, 29);
            this.button_limpar.TabIndex = 2;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_HashSet
            // 
            this.button_HashSet.Location = new System.Drawing.Point(591, 53);
            this.button_HashSet.Name = "button_HashSet";
            this.button_HashSet.Size = new System.Drawing.Size(181, 35);
            this.button_HashSet.TabIndex = 3;
            this.button_HashSet.Text = "HashSet";
            this.button_HashSet.UseVisualStyleBackColor = true;
            this.button_HashSet.Click += new System.EventHandler(this.button_HashSet_Click);
            // 
            // button_Dictionary
            // 
            this.button_Dictionary.Location = new System.Drawing.Point(591, 94);
            this.button_Dictionary.Name = "button_Dictionary";
            this.button_Dictionary.Size = new System.Drawing.Size(181, 35);
            this.button_Dictionary.TabIndex = 4;
            this.button_Dictionary.Text = "Dictionary";
            this.button_Dictionary.UseVisualStyleBackColor = true;
            this.button_Dictionary.Click += new System.EventHandler(this.button_Dictionary_Click);
            // 
            // button_SortedList
            // 
            this.button_SortedList.Location = new System.Drawing.Point(591, 135);
            this.button_SortedList.Name = "button_SortedList";
            this.button_SortedList.Size = new System.Drawing.Size(181, 34);
            this.button_SortedList.TabIndex = 5;
            this.button_SortedList.Text = "SortedList";
            this.button_SortedList.UseVisualStyleBackColor = true;
            this.button_SortedList.Click += new System.EventHandler(this.button_SortedList_Click);
            // 
            // button_SortedDictionary
            // 
            this.button_SortedDictionary.Location = new System.Drawing.Point(591, 175);
            this.button_SortedDictionary.Name = "button_SortedDictionary";
            this.button_SortedDictionary.Size = new System.Drawing.Size(181, 34);
            this.button_SortedDictionary.TabIndex = 6;
            this.button_SortedDictionary.Text = "SortedDictionary";
            this.button_SortedDictionary.UseVisualStyleBackColor = true;
            this.button_SortedDictionary.Click += new System.EventHandler(this.button_SortedDictionary_Click);
            // 
            // button_SortedSet
            // 
            this.button_SortedSet.Location = new System.Drawing.Point(591, 215);
            this.button_SortedSet.Name = "button_SortedSet";
            this.button_SortedSet.Size = new System.Drawing.Size(181, 33);
            this.button_SortedSet.TabIndex = 7;
            this.button_SortedSet.Text = "SortedSet";
            this.button_SortedSet.UseVisualStyleBackColor = true;
            this.button_SortedSet.Click += new System.EventHandler(this.button_SortedSet_Click);
            // 
            // button_Queue
            // 
            this.button_Queue.Location = new System.Drawing.Point(591, 254);
            this.button_Queue.Name = "button_Queue";
            this.button_Queue.Size = new System.Drawing.Size(181, 33);
            this.button_Queue.TabIndex = 8;
            this.button_Queue.Text = "Queue";
            this.button_Queue.UseVisualStyleBackColor = true;
            this.button_Queue.Click += new System.EventHandler(this.button_Queue_Click);
            // 
            // button_Stack
            // 
            this.button_Stack.Location = new System.Drawing.Point(591, 293);
            this.button_Stack.Name = "button_Stack";
            this.button_Stack.Size = new System.Drawing.Size(181, 32);
            this.button_Stack.TabIndex = 9;
            this.button_Stack.Text = "Stack";
            this.button_Stack.UseVisualStyleBackColor = true;
            this.button_Stack.Click += new System.EventHandler(this.button_Stack_Click);
            // 
            // Colecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button_Stack);
            this.Controls.Add(this.button_Queue);
            this.Controls.Add(this.button_SortedSet);
            this.Controls.Add(this.button_SortedDictionary);
            this.Controls.Add(this.button_SortedList);
            this.Controls.Add(this.button_Dictionary);
            this.Controls.Add(this.button_HashSet);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_List);
            this.Controls.Add(this.lista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Colecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Genéricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_HashSet;
        private System.Windows.Forms.Button button_Dictionary;
        private System.Windows.Forms.Button button_SortedList;
        private System.Windows.Forms.Button button_SortedDictionary;
        private System.Windows.Forms.Button button_SortedSet;
        private System.Windows.Forms.Button button_Queue;
        private System.Windows.Forms.Button button_Stack;
    }
}

