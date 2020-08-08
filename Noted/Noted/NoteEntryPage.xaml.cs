using System;
using System.IO;
using System.Text;
using Xamarin.Forms;
using Noted.Models;

namespace Noted
{
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (note.Title == null)
            {
                await DisplayAlert("Error!", "Please enter a title for your note.", "OK");
                return;
            }

            note.Title = note.Title.Trim();
            note.Content = note.Content == null ? note.Content : note.Content.Trim();
            note.DateCreated = DateTime.UtcNow;

            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}