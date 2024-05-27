using System;
using System.Windows.Forms;
using TourAgency.Models;
using TourAgency.Services;

namespace TourAgency
{
    public partial class AddEditTourForm : Form
    {
        private readonly ITourService _tourService;
        private readonly Tour _tour;

        public AddEditTourForm(ITourService tourService)
        {
            _tourService = tourService;
            InitializeComponent();
            LoadTourTypes();
            LoadStatuses();
        }

        public AddEditTourForm(ITourService tourService, Tour tour)
        {
            _tourService = tourService;
            _tour = tour;
            InitializeComponent();
            LoadTourData();
            LoadTourTypes();
            LoadStatuses();
        }

        private void LoadTourTypes()
        {
            comboBoxTourType.Items.Add("Standard");
            comboBoxTourType.Items.Add("Premium");

            if (_tour != null)
            {
                if (_tour is PremiumTour)
                {
                    comboBoxTourType.SelectedItem = "Premium";
                }
                else
                {
                    comboBoxTourType.SelectedItem = "Standard";
                }
            }
            else
            {
                comboBoxTourType.SelectedItem = "Standard";
            }
        }

        private void LoadStatuses()
        {
            comboBoxStatus.Items.Add("Available");
            comboBoxStatus.Items.Add("Booked");
            comboBoxStatus.Items.Add("Cancelled");

            if (_tour != null)
            {
                comboBoxStatus.SelectedItem = _tour.Status;
            }
            else
            {
                comboBoxStatus.SelectedItem = "Available";
            }
        }

        private void LoadTourData()
        {
            if (_tour != null)
            {
                textBoxDepCity.Text = _tour.DepartureCity;
                textBoxDesCountry.Text = _tour.DestinationCountry;
                dateTimePickerDepDate.Value = _tour.DepartureDate.ToLocalTime();
                dateTimePickerRetDate.Value = _tour.ReturnDate.ToLocalTime();
                textBoxPrice.Text = _tour.Price.ToString();
                textBoxDescription.Text = _tour.Description;
                button2.Text = "Оновити";
                label1.Text = "Редагувати тур";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (_tour == null)
                {
                    Tour newTour;
                    if (comboBoxTourType.SelectedItem.ToString() == "Premium")
                    {
                        newTour = new PremiumTour
                        {
                            DepartureCity = textBoxDepCity.Text,
                            DestinationCountry = textBoxDesCountry.Text,
                            DepartureDate = dateTimePickerDepDate.Value.ToUniversalTime(),
                            ReturnDate = dateTimePickerRetDate.Value.ToUniversalTime(),
                            Price = decimal.Parse(textBoxPrice.Text),
                            Description = textBoxDescription.Text,
                            Status = comboBoxStatus.SelectedItem.ToString()
                        };
                    }
                    else
                    {
                        newTour = new StandardTour
                        {
                            DepartureCity = textBoxDepCity.Text,
                            DestinationCountry = textBoxDesCountry.Text,
                            DepartureDate = dateTimePickerDepDate.Value.ToUniversalTime(),
                            ReturnDate = dateTimePickerRetDate.Value.ToUniversalTime(),
                            Price = decimal.Parse(textBoxPrice.Text),
                            Description = textBoxDescription.Text,
                            Status = comboBoxStatus.SelectedItem.ToString()
                        };
                    }

                    _tourService.AddTour(newTour);
                    MessageBox.Show("Tour added successfully!");
                }
                else
                {
                    _tour.DepartureCity = textBoxDepCity.Text;
                    _tour.DestinationCountry = textBoxDesCountry.Text;
                    _tour.DepartureDate = dateTimePickerDepDate.Value.ToUniversalTime();
                    _tour.ReturnDate = dateTimePickerRetDate.Value.ToUniversalTime();
                    _tour.Price = decimal.Parse(textBoxPrice.Text);
                    _tour.Description = textBoxDescription.Text;
                    _tour.Status = comboBoxStatus.SelectedItem.ToString();

                    _tourService.UpdateTour(_tour);
                    MessageBox.Show("Tour updated successfully!");
                }

                this.Close();
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(textBoxDepCity.Text) ||
                string.IsNullOrEmpty(textBoxDesCountry.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text) ||
                string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out _))
            {
                MessageBox.Show("Invalid price format.");
                return false;
            }

            return true;
        }

        private void comboBoxTourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add logic here to update the form based on the selected tour type if necessary
        }
    }
}
