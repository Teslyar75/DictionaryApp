using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DictionaryApp
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Ellipse> ellipseMappings;
        private Ellipse currentColoredEllipse;


        public MainWindow()
        {
            InitializeComponent();
            ellipseMappings = new Dictionary<string, Ellipse>
                {
                    { "button1", ellipse1 },
                    { "button2", ellipse2 },
                    { "button3", ellipse3 },
                    { "button4", ellipse4 },
                    { "button5", ellipse5 },
                    { "button6", ellipse6 },
                    { "button7", ellipse7 },
                    { "button15", ellipse8 },
                };

            button1.Click += LeftButtonClick;
            button2.Click += LeftButtonClick;
            button3.Click += LeftButtonClick;
            button4.Click += LeftButtonClick;
            button5.Click += LeftButtonClick;
            button6.Click += LeftButtonClick;
            button7.Click += LeftButtonClick;
            button15.Click += LeftButtonClick;

        }




        private void LeftButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            Console.WriteLine($"Clicked: {clickedButton.Name}");
            UpdateRightButtonContent(clickedButton.Name);
            UpdateEllipsesColor(clickedButton.Name);
        }

        private void UpdateEllipsesColor(string leftButtonName)
        {
            // Получите эллипс, соответствующий нажатой кнопке
            if (ellipseMappings.TryGetValue(leftButtonName, out Ellipse correspondingEllipse))
            {
                // Если уже есть окрашенный эллипс, снимите окраску
                if (currentColoredEllipse != null)
                {
                    currentColoredEllipse.Fill = Brushes.Transparent;
                }

                // Получите ресурс по имени кнопки
                object colorResource = FindResource(leftButtonName + "Color");

                if (colorResource is SolidColorBrush buttonBrush)
                {
                    // Установите цвет заполнения эллипса в цвет соответствующей кнопки
                    correspondingEllipse.Fill = buttonBrush;

                    // Обновите текущий окрашенный эллипс
                    currentColoredEllipse = correspondingEllipse;
                }
            }
        }


       
        private void UpdateRightButtonContent(string leftButtonName)
        {
            // Сбросить цвет для всех кнопок перед установкой нового цвета
            button8.Background = Brushes.Transparent;
            button9.Background = Brushes.Transparent;
            button10.Background = Brushes.Transparent;
            button11.Background = Brushes.Transparent;
            button12.Background = Brushes.Transparent;
            button13.Background = Brushes.Transparent;
            button14.Background = Brushes.Transparent;
            button16.Background = Brushes.Transparent;

            // Установка нового цвета в зависимости от кнопки
            switch (leftButtonName)
            {
                case "button1":
                    button8.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF66E58"); // Красный с 20% прозрачности
                    
                    break;

                case "button2":
                    button9.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF48E54"); // Оранжевый с 20% прозрачности
                    break;

                case "button3":
                    button10.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF7E151"); // Желтый с 20% прозрачности
                    break;

                case "button4":
                    button11.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF6FEA6E"); // Зеленый с 20% прозрачности
                    break;

                case "button5":
                    button12.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF6EE6EA"); // Синий с 20% прозрачности
                    break;

                case "button6":
                    button13.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF6E83EA"); // Темно-синий с 20% прозрачности
                    break;

                case "button7":
                    button14.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFBC6EEA"); // Фиолетовый с 20% прозрачности
                    break;

                case "button15":
                    button16.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFC1CF99"); // Оливковый с 20% прозрачности
                    break;
            }

           

        }
        private void SaveDictionaryButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения словаря
            string dictionaryName = ((TextBox)button8.Template.FindName("DictionaryNameTextBox", button8)).Text;
            // Добавьте здесь ваш код для сохранения словаря с указанным именем
        }

    }

   
}
