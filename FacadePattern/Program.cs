using FacadePattern;

var amp = new Amplifier();
var cdPlayer = new CdPlayer(amp);
var dvdPlayer = new DvdPlayer(amp);
var popcornPopper = new PopcornPopper();
var projector = new Projector();
var screen = new Screen();
var lights = new TheaterLights();
var tuner = new Tuner(amp);

var homeTheater = new HomeTheaterFacade(
    amp,
    tuner,
    dvdPlayer,
    cdPlayer,
    projector,
    lights,
    screen,
    popcornPopper);
homeTheater.WatchMovie("The Matrix");

homeTheater.EndMovie();