using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    class HomeTheaterFacade
    {
        public Amplifier amp;
        public CdPlayer cd;
        public DvdPlayer dvd;
        public PopcornPopper popcorn;
        public Projector projector;
        public Screen screen;
        public TheaterLights lights;
        public Tuner tuner;

        public HomeTheaterFacade(Amplifier amp, CdPlayer cd, DvdPlayer dvd,
                                PopcornPopper popcorn, Projector projector,
                                Screen screen, TheaterLights lights, Tuner tuner)
        {
            this.amp = amp;
            this.cd = cd;
            this.dvd = dvd;
            this.popcorn = popcorn;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.tuner = tuner;
        }

        public HomeTheaterFacade()
        {
            this.amp = new Amplifier();
            this.cd = new CdPlayer();
            this.dvd = new DvdPlayer();
            this.popcorn = new PopcornPopper();
            this.projector = new Projector();
            this.screen = new Screen();
            this.lights = new TheaterLights();
            this.tuner = new Tuner();
        }

        public void watchMovie(String movie)
        {
            popcorn.on();
            popcorn.pop();
            lights.on();
            lights.dim();
            lights.dim();
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setVolume(11);
            dvd.on();
            dvd.setSurroundAudio();
            dvd.play(movie);
            displayStatus();
        }

        public void endMovie()
        {
            popcorn.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
            displayStatus();
        }


        public void displayStatus()
        {
            amp.displayStatus();
            cd.dislayStatus();
            dvd.dislayStatus();
            popcorn.displayStatus();
            projector.displaySatus();
            screen.displayStatus();
            lights.displayStatus();
            tuner.displayStatus();
        }
    }
}
