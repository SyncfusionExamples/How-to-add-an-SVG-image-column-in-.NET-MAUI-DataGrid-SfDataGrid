﻿using System.ComponentModel;

namespace SfDataGridSample
{
    public class Employee : INotifyPropertyChanged
    {
        private bool _isSelected;
        private int? _employeeID;
        private string? _name;
        private long _iDNumber;
        private int _contactID;
        private string? _loginID;
        private int _managerID;
        private string? _title;
        private DateTime _birthDate;
        private string? _maritalStatus;
        private string? _gender;
        private DateTime _hireDate;
        private int _sickLeaveHours;
        private double _salary;
        private bool _employeeStatus;
        private int _rating;
        private bool _isButtonVisible;
        private string _imagePath;

        public string ImagePath {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged(nameof(ImagePath)); }
        }
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged(nameof(IsSelected)); }
        }

        public int? EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; OnPropertyChanged(nameof(EmployeeID)); }
        }
        public string? Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public long IDNumber
        {
            get { return _iDNumber; }
            set { _iDNumber = value; OnPropertyChanged(nameof(IDNumber)); }
        }
        public string? Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(nameof(Title)); }
        }
        public int ContactID
        {
            get { return _contactID; }
            set { _contactID = value; OnPropertyChanged(nameof(ContactID)); }
        }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChanged(nameof(BirthDate)); }
        }
        public string? MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; OnPropertyChanged(nameof(MaritalStatus)); }
        }
        public string? Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(nameof(Gender)); }
        }
        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; OnPropertyChanged(nameof(HireDate)); }
        }
        public int SickLeaveHours
        {
            get { return _sickLeaveHours; }
            set { _sickLeaveHours = value; OnPropertyChanged(nameof(SickLeaveHours)); }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; OnPropertyChanged(nameof(Salary)); }
        }
        public string? LoginID
        {
            get { return _loginID; }
            set { _loginID = value; OnPropertyChanged(nameof(LoginID)); }
        }
        public int ManagerID
        {
            get { return _managerID; }
            set { _managerID = value; OnPropertyChanged(nameof(ManagerID)); }
        }
        public bool EmployeeStatus
        {
            get { return _employeeStatus; }
            set { _employeeStatus = value; OnPropertyChanged(nameof(EmployeeStatus)); }
        }
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; OnPropertyChanged(nameof(Rating)); }
        }

        public bool IsButtonVisible
        {
            get { return _isButtonVisible; }
            set { _isButtonVisible = value; OnPropertyChanged(nameof(IsButtonVisible)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}