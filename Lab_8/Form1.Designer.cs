﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_8
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
            newCntUsers = new NumericUpDown();
            label6 = new Label();
            newPrice = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            nameSelector = new ComboBox();
            editButton = new Button();
            deleteButton = new Button();
            editingPanel = new Panel();
            addingPanel = new Panel();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cntUsers = new NumericUpDown();
            price = new NumericUpDown();
            nameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)newCntUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newPrice).BeginInit();
            editingPanel.SuspendLayout();
            addingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            SuspendLayout();
            // 
            // newCntUsers
            // 
            newCntUsers.Location = new Point(16, 99);
            newCntUsers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            newCntUsers.Name = "newCntUsers";
            newCntUsers.Size = new Size(99, 23);
            newCntUsers.TabIndex = 9;
            newCntUsers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 21);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 10;
            label6.Text = "Имя оператора";
            // 
            // newPrice
            // 
            newPrice.Location = new Point(15, 56);
            newPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            newPrice.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            newPrice.Name = "newPrice";
            newPrice.Size = new Size(100, 23);
            newPrice.TabIndex = 8;
            newPrice.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 58);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 107);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 12;
            label4.Text = "Кол-во пользователей";
            // 
            // nameSelector
            // 
            nameSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            nameSelector.FormattingEnabled = true;
            nameSelector.Location = new Point(15, 18);
            nameSelector.Name = "nameSelector";
            nameSelector.Size = new Size(121, 23);
            nameSelector.TabIndex = 13;
            nameSelector.SelectedIndexChanged += nameSelector_SelectedIndexChanged;
            // 
            // editButton
            // 
            editButton.Location = new Point(15, 167);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(159, 167);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editingPanel
            // 
            editingPanel.Controls.Add(deleteButton);
            editingPanel.Controls.Add(editButton);
            editingPanel.Controls.Add(nameSelector);
            editingPanel.Controls.Add(label4);
            editingPanel.Controls.Add(label5);
            editingPanel.Controls.Add(newPrice);
            editingPanel.Controls.Add(label6);
            editingPanel.Controls.Add(newCntUsers);
            editingPanel.Location = new Point(496, 64);
            editingPanel.Name = "editingPanel";
            editingPanel.Size = new Size(272, 205);
            editingPanel.TabIndex = 1;
            // 
            // addingPanel
            // 
            addingPanel.Controls.Add(createButton);
            addingPanel.Controls.Add(label3);
            addingPanel.Controls.Add(label2);
            addingPanel.Controls.Add(label1);
            addingPanel.Controls.Add(cntUsers);
            addingPanel.Controls.Add(price);
            addingPanel.Controls.Add(nameBox);
            addingPanel.Location = new Point(77, 70);
            addingPanel.Name = "addingPanel";
            addingPanel.Size = new Size(256, 205);
            addingPanel.TabIndex = 4;
            // 
            // createButton
            // 
            createButton.Location = new Point(91, 167);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 6;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 112);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 5;
            label3.Text = "Кол-во пользователей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 63);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 24);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Имя оператора";
            // 
            // cntUsers
            // 
            cntUsers.Location = new Point(13, 104);
            cntUsers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cntUsers.Name = "cntUsers";
            cntUsers.Size = new Size(99, 23);
            cntUsers.TabIndex = 2;
            cntUsers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // price
            // 
            price.Location = new Point(12, 61);
            price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            price.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 1;
            price.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 21);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(addingPanel);
            Controls.Add(editingPanel);
            Name = "Form1";
            Text = "Лабораторная работа 8. Паттерн MVP. Вариант 10. Ермаков, Петровский";
            ((System.ComponentModel.ISupportInitialize)newCntUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)newPrice).EndInit();
            editingPanel.ResumeLayout(false);
            editingPanel.PerformLayout();
            addingPanel.ResumeLayout(false);
            addingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown newCntUsers;
        private Label label6;
        private NumericUpDown newPrice;
        private Label label5;
        private Label label4;
        private ComboBox nameSelector;
        private Button editButton;
        private Button deleteButton;
        private Panel editingPanel;
        private Panel addingPanel;
        private Button createButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cntUsers;
        private NumericUpDown price;
        private TextBox nameBox;
    }
}
