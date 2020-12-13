using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;
using System.Windows.Forms;


namespace Lab2
{
    public partial class BiblWorm : Form
    {
        #region BooksFormProperties
            public string BooksAuthor // автор
            {
                get { return textBoxBookAuthor.Text; }
                set { textBoxBookAuthor.Text = value; }
            }
            public string BooksTitle // Название
            {
                get { return textBoxBookTitle.Text; }
                set { textBoxBookTitle.Text = value; }
            }
            public string BooksPublishHouse // Издательство
            {
                get { return textBoxBookPublisher.Text; }
                set { textBoxBookPublisher.Text = value; }
            }
            public int BooksPagesCount // Количество страниц
            {
                get { return (int)numericUpDownBookPagesCount.Value; }
                set { numericUpDownBookPagesCount.Value = value; }
            }
            public int BooksPublishedYear // Год издания
            {
                get { return (int)numericUpDownBookYearPublished.Value; }
                set { numericUpDownBookYearPublished.Value = value; }
            }
            public int BooksInvNumber // Инвентарный номер
            {
                get { return (int)numericUpDownBookInvNumber.Value; }
                set { numericUpDownBookInvNumber.Value = value; }
            }
            public bool IsBookAvailable // Наличие
            {
                get { return checkBoxIsBookAvailable.Checked; }
                set { checkBoxIsBookAvailable.Checked = value; }
            }
            public bool IsBookSortByInvNumber // Сортировка по инвентарному номеру
            {
                get { return checkBoxIsBooksListSort.Checked; }
                set { checkBoxIsBooksListSort.Checked = value; }
            }
            public bool IsBookReturnOnTime // Возвращение в срок
            {
                get { return checkBoxIsBookReturnOnTime.Checked; }
                set { checkBoxIsBookReturnOnTime.Checked = value; }
            }
            public int BooksPeriodUse 
            {
                get { return (int)numericUpDownBookUsingPeriod.Value; }

                set { numericUpDownBookUsingPeriod.Value = value; }
            }

            List<Item> booksList = new List<Item>();
        #endregion

        #region MagazineFormProperties
        public string MagazineTitle 
        {
            get { return textBoxMagazineTitle.Text; }
            set { textBoxMagazineTitle.Text = value; }
        }
        public string MagazineVolume 
        {
            get { return textBoxMagazineVolume.Text; }
            set { textBoxMagazineVolume.Text = value; }
        }
        public int MagazineDateOfPublished 
        {
            get { return (int)numericUpDownMagainePublishedDate.Value; }
            set { numericUpDownMagainePublishedDate.Value = value; } 
        }
        public int MagazineNumber 
        {
            get { return (int)numericUpDownMagazineNumber.Value; }
            set { numericUpDownMagazineNumber.Value = value; } 
        }
        public int MagazineInvNumber 
        {
            get { return (int)numericUpDowMagazineInvNumber.Value; }
            set { numericUpDowMagazineInvNumber.Value = value; } 
        }
        public bool  IsMagazineAvailable 
        {
            get { return checkBoxIsMagazineAvailable.Checked; }
            set { checkBoxIsMagazineAvailable.Checked = value; }
        }
        public bool IsMagazineListSort 
        {
            get { return checkBoxIsMagazineListSort.Checked; }
            set { checkBoxIsMagazineListSort.Checked = value; }
        }
        List<Item> magazinesList = new List<Item>();
        #endregion

        public BiblWorm()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book(BooksAuthor, BooksTitle, BooksPublishHouse,BooksPagesCount, BooksPublishedYear, BooksInvNumber, IsBookAvailable);
            //проверка возврата книги в срок:
            if (IsBookReturnOnTime) 
            {
                b.ReturnSrok();
            }
                
            //расчет стоимости с учетом срока пользования книгой:
            b.PriceBook(BooksPeriodUse);
            //добавление книги в список:
            booksList.Add(b);
            //очистка поля ввода для новой информации
            BooksAuthor = BooksTitle = BooksPublishHouse = "";
            BooksPagesCount = BooksInvNumber = BooksPeriodUse = 1;
            BooksPublishedYear = 1950;
            IsBookAvailable = IsBookReturnOnTime = false;
        }

        private void cmdWatch_Click(object sender, EventArgs e)
        {
            if (IsBookSortByInvNumber)
                booksList.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in booksList)
            {
                sb.Append("\n" + item.ToString());
            }

            richTextBoxBooksList.Text = sb.ToString();
        }

        private void cmdAddMagazine_Click(object sender, EventArgs e)
        {
            Magazine magazine = new Magazine(MagazineVolume, MagazineNumber, MagazineTitle, MagazineDateOfPublished, 
                MagazineInvNumber, IsMagazineAvailable);

            //добавление журнала в список:
            magazinesList.Add(magazine);
            //очистка поля ввода для новой информации
            MagazineVolume = MagazineTitle = string.Empty;
            MagazineDateOfPublished = 1950;
            MagazineInvNumber = MagazineNumber = 0;
            IsMagazineAvailable = IsMagazineListSort = false;
        }

        private void cmdWatchMagazinesList_Click(object sender, EventArgs e)
        {
            if (IsMagazineListSort)
                magazinesList.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in magazinesList)
            {
                sb.Append("\n" + item.ToString());
            }

            richTextBoxMagazineList.Text = sb.ToString();
        }
    }
}
