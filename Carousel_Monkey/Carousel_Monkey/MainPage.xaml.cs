using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace Carousel_Monkey
{
    public partial class MainPage : CarouselPage
    {
        ContentPage page, page2, page3, page4, page5;
        public MainPage()
        {

            page5 = new ContentPage()
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Swipe to the right --->",
                            FontSize = 35,
                            TextColor = Color.Black,
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center,
                        }
                    }
                }
            };
            ContentPage MainInfo(ContentPage mainPage, string monkeyName, string imagePath, string mainContent)
            {
                Image img;
                img = new Image
                {
                    HeightRequest = 170,
                    WidthRequest = 170,
                    HorizontalOptions = LayoutOptions.Center,
                    Aspect = Aspect.AspectFill,
                    Source = imagePath,
                };
                var tap = new TapGestureRecognizer();
                tap.Tapped += Tap_Tapped; ;
                img.GestureRecognizers.Add(tap);
                mainPage = new ContentPage()
                {
                    Content = new Frame
                    {
                        CornerRadius = 5,
                        Margin = 20,
                        HasShadow = true,
                        HeightRequest = 300,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,

                        Content = new StackLayout
                        {

                            Children =
                            {
                                new Label
                                {
                                    Text = monkeyName,
                                    FontAttributes = FontAttributes.Bold,

                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                },
                                img,
                                new Label
                                {
                                    Text = "Africa",
                                    HorizontalOptions = LayoutOptions.Center,
                                },
                                new Label
                                {
                                    Text = mainContent,
                                    FontAttributes = FontAttributes.Italic,
                                    HorizontalOptions = LayoutOptions.Center,
                                    MaxLines = 5,
                                    LineBreakMode = LineBreakMode.TailTruncation,
                                },
                            }
                        }
                    }
                };

                return mainPage;
                
            };
            Children.Add(page5);
            Children.Add(MainInfo(page, "Vervet monkey", "Vervet_Monkey.jpg", "The vervet monkey (Chlorocebus pygerythrus), or simply vervet, is an Old World monkey of the family Cercopithecidae native to Africa. The term 'vervet' is also used to refer to all the members of the genus Chlorocebus."));
            Children.Add(MainInfo(page2, "Lorisoidea monkey", "Greater_Galago.jpg", "Lorisoidea is a superfamily of nocturnal primates found throughout Africa and Asia. Members include the galagos and the lorisids."));
            Children.Add(MainInfo(page3, "Cheirogaleidae monkey", "Rode.jpg", "The Cheirogaleidae are the family of strepsirrhine primates containing the various dwarf and mouse lemurs. Like all other lemurs, cheirogaleids live exclusively on the island of Madagascar."));
            Children.Add(MainInfo(page4, "Indriidae monkey", "Indri.jpg", "The Indriidae (sometimes incorrectly spelled Indridae) are a family of strepsirrhine primates. They are medium- to large-sized lemurs, with only four teeth in the toothcomb instead of the usual six. Indriids, like all lemurs, live exclusively on the island of Madagascar."));

        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;
            var selectedImage = imageSender.Source as FileImageSource;
            if (selectedImage.File == "Vervet_Monkey.jpg")
            {
                bool action = await DisplayAlert("Success", string.Format("Want to see more? {0}", ""), "Yes", "No");
                if (action)
                {
                    Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Vervet_monkey"));
                }

            }
            else if(selectedImage.File == "Greater_Galago.jpg")
            {
                bool action = await DisplayAlert("Success", string.Format("Want to see more? {0}", ""), "Yes", "No");
                if (action)
                {
                    Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Galago"));
                }
                
            }
            else if(selectedImage.File == "Rode.jpg")
            {
                bool action = await DisplayAlert("Success", string.Format("Want to see more? {0}", ""), "Yes", "No");
                if (action)
                {
                    Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Cheirogaleidae"));
                }
                
            }
            else if(selectedImage.File == "Indri.jpg")
            {
                bool action = await DisplayAlert("Success", string.Format("Want to see more? {0}", ""), "Yes", "No");
                if (action)
                {
                    Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Indriidae"));
                }
                
            }   

        }
    }
}
