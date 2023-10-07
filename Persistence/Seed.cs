using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context){
            if(!context.NasaPotds.Any())
            {
                var NasaPotds = new List<NasaPotd>
                {
                    new NasaPotd {
                            Date = "2023-09-25",
                            Explanation = "What's happening to this spiral galaxy? Just a few hundred million years ago, NGC 2936, the upper of the two large galaxies shown at the bottom, was likely a normal spiral galaxy -- spinning, creating stars -- and minding its own business. But then it got too close to the massive elliptical galaxy NGC 2937, just below, and took a turn. Sometimes dubbed the Hummingbird Galaxy for its iconic shape, NGC 2936 is not only being deflected but also being distorted by the close gravitational interaction. Behind filaments of dark interstellar dust, bright blue stars form the nose of the hummingbird, while the center of the spiral appears as an eye.  Alternatively, the galaxy pair, together known as Arp 142, look to some like Porpoise or a penguin protecting an egg. The featured re-processed image showing Arp 142 in great detail was taken recently by the Hubble Space Telescope. Arp 142 lies about 300 million light years away toward the constellation of the Water Snake (Hydra). In a billion years or so the two galaxies will likely merge into one larger galaxy.",
                            Media_Type = MediaType.image,
                            Service_Version = "v1",
                            Title = "Arp 142: The Hummingbird Galaxy",
                            url = "https://apod.nasa.gov/apod/image/2309/Arp142_HubbleChakrabarti_960.jpg",
                            hdurl = "https://apod.nasa.gov/apod/image/2309/Arp142_HubbleChakrabarti_2627.jpg"

                        },
                    new NasaPotd {
                            Date = "2023-09-26",
                            Explanation = "Do you see the horse's head?   What you are seeing is not the famous Horsehead nebula toward Orion, but rather a fainter nebula that only takes on a familiar form with deeper imaging.  The main part of the here-imaged molecular cloud complex is  reflection nebula IC 4592.  Reflection nebulas are made up of very fine dust that normally appears dark but can look quite blue when reflecting the visible light of energetic nearby stars.  In this case, the source of much of the reflected light is a star at the eye of the horse.  That star is part of Nu Scorpii, one of the brighter star systems toward the constellation of the Scorpion (Scorpius).   A second reflection nebula dubbed IC 4601 is visible surrounding two stars above and to the right of the image center.",
                            Media_Type = MediaType.image,
                            Service_Version = "v1",
                            Title = "IC 4592: The Blue Horsehead Reflection Nebula",
                            url = "https://apod.nasa.gov/apod/image/2309/BlueHorse_Grelin_1080.jpg",
                            hdurl = "https://apod.nasa.gov/apod/image/2309/BlueHorse_Grelin_9342.jpg"
                        },
                    new NasaPotd {
                            Date = "2023-09-27",
                            Explanation = "Not every road ends in a STEVE. A week ago, a sky enthusiast's journey began with a goal: to photograph an aurora over Lake Huron. Driving through rural Ontario, Canada, the forecasted sky show started unexpectedly early, causing the photographer to stop before arriving at the scenic Great Lake. Aurora images were taken toward the north -- but over land, not sea. While waiting for a second round of auroras, a peculiar band of light was noticed to the west.  Slowly, the photographer and friends realized that this western band was likely an unusual type of aurora: a Strong Thermal Emission Velocity Enhancement (STEVE). Moreover, this STEVE was putting on quite a show: appearing intertwined with the central band of our Milky Way Galaxy while intersecting the horizon just near the end of the country road. After capturing this cosmic X on camera, the photographer paused to appreciate the unexpected awesomeness of finding extraordinary beauty in an ordinary setting.     Your Sky Surprise: What picture did APOD feature on your birthday? (post 1995)",
                            Media_Type = MediaType.image,
                            Service_Version = "v1",
                            Title = "STEVE and Milky Way Cross over Rural Road",
                            url = "https://apod.nasa.gov/apod/image/2309/SteveMw_Clarke_960.jpg",
                            hdurl = "https://apod.nasa.gov/apod/image/2309/SteveMw_Clarke_4177.jpg"
                        }
                };

                context.NasaPotds.AddRange(NasaPotds);
                context.SaveChanges();
            }

            
        }
    }
}