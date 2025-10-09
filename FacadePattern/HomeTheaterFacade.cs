namespace FacadePattern;

internal class HomeTheaterFacade(
    Amplifier amp,
    Tuner tuner,
    DvdPlayer dvdPlayer,
    CdPlayer cdPlayer,
    Projector projector,
    TheaterLights lights,
    Screen screen,
    PopcornPopper popcornPopper)
{
    public void WatchMovie(string movie)
    {
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
        popcornPopper.Off();

        lights.On();

        screen.Up();

        projector.Off();

        amp.Off();

        dvdPlayer.Stop();
        dvdPlayer.Eject();
    }
}