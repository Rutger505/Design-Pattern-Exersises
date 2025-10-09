namespace FacadePattern;

public class HomeTheaterFacade
{
    public void WatchMovie(string movie)
    {
        var amp = new Amplifier();
        var cdPlayer = new CdPlayer(amp);
        var dvdPlayer = new DvdPlayer(amp);
        var popcornPopper = new PopcornPopper();
        var projector = new Projector();
        var screen = new Screen();
        var lights = new TheaterLights();
        var tuner = new Tuner(amp);


        popcornPopper.On();
        popcornPopper.Pop();

        lights.Dim(10);

        screen.Down();

        projector.On();
        projector.SetInput(dvdPlayer);
        projector.WideScreenMode();

        amp.On();
        amp.SetDvd(dvdPlayer);
        amp.SetSurroundSound();
        amp.SetVolume(5);

        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
    }
}