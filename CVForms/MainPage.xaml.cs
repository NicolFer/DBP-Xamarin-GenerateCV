using System;
using Xamarin.Forms;

namespace CVForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método para agregar una experiencia laboral
        private void OnAddExperienceClicked(object sender, EventArgs e)
        {
            var experienceLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Entry { Placeholder = "Puesto", WidthRequest = 150 },
                    new Entry { Placeholder = "Año", WidthRequest = 100 },
                    new Editor { Placeholder = "Descripción", HeightRequest = 60, WidthRequest = 200 }
                }
            };

            experienciaStack.Children.Add(experienceLayout);
        }

        // Método para agregar una formación académica
        private void OnAddEducationClicked(object sender, EventArgs e)
        {
            var educationLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Entry { Placeholder = "Licencia", WidthRequest = 150 },
                    new Entry { Placeholder = "Año", WidthRequest = 100 },
                    new Entry { Placeholder = "Lugar de estudio", WidthRequest = 200 }
                }
            };

            formacionStack.Children.Add(educationLayout);
        }

        // Método para agregar una habilidad
        private void OnAddSkillClicked(object sender, EventArgs e)
        {
            var skillLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Entry { Placeholder = "Habilidad", WidthRequest = 200 }
                }
            };

            habilidadesStack.Children.Add(skillLayout);
        }

        // Método para agregar un idioma
        private void OnAddLanguageClicked(object sender, EventArgs e)
        {
            var languageLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Entry { Placeholder = "Idioma", WidthRequest = 150 },
                    new Entry { Placeholder = "Nivel", WidthRequest = 100 }
                }
            };

            idiomasStack.Children.Add(languageLayout);
        }

        // Método para agregar una sección en "Otros"
        private void OnAddOtherClicked(object sender, EventArgs e)
        {
            var otherLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Entry { Placeholder = "Título", WidthRequest = 150 },
                    new Editor { Placeholder = "Descripción", HeightRequest = 60, WidthRequest = 200 }
                }
            };

            otrosStack.Children.Add(otherLayout);
        }

        // Método para generar el CV
        private void OnGenerateCVClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para generar un CV en formato PDF, texto, etc.
            DisplayAlert("Generando CV", "Tu CV ha sido generado.", "OK");
        }
    }
}
