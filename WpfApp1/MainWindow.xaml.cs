﻿using LibraryProject.Data.Repositories.Concretes;
using LibraryProject.Models.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Repository<Category> repository = new Repository<Category>();
            Category category = new Category();
            for (int i = 0; i <20; i++)
            { 
            category.Name = "Seymurun gotu";
            category.ModefiedDate = DateTime.Now;
            repository.Update(category);
            repository.SaveChange();

            }


        }
    }
}
