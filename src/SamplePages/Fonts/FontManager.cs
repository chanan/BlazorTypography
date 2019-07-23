using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SamplePages.Fonts
{
    public class FontManager
    {
        public FontManager()
        {
            List<Font> temp = JsonSerializer.Parse<List<Font>>(_fonts);
            Fonts = temp;
        }
        public List<Font> Fonts { get; private set; }

        private const string _fonts = @"
[
{
""Category"": ""sans-serif"",
""Family"": ""Open Sans"",
""Weights"": [
""300"",
""600"",
""700"",
""800"",
""300italic"",
""regular"",
""italic"",
""600italic"",
""700italic"",
""800italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Roboto"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""900"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Slabo 27px"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Lato"",
""Weights"": [
""100"",
""300"",
""700"",
""900"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Oswald"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Roboto Condensed"",
""Weights"": [
""300"",
""700"",
""300italic"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Source Sans Pro"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""900"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""600italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Montserrat"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Raleway"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""PT Sans"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Lora"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Roboto Slab"",
""Weights"": [
""100"",
""300"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Open Sans Condensed"",
""Weights"": [
""300"",
""700"",
""300italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Droid Sans"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ubuntu"",
""Weights"": [
""300"",
""500"",
""700"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Droid Serif"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Merriweather"",
""Weights"": [
""300"",
""700"",
""900"",
""300italic"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Arimo"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""PT Sans Narrow"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Noto Sans"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Titillium Web"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""900"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""PT Serif"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Playfair Display"",
""Weights"": [
""700"",
""900"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Fjalla One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Indie Flower"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Bitter"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Muli"",
""Weights"": [
""300"",
""300italic"",
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Oxygen"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Inconsolata"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Dosis"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hind"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cabin"",
""Weights"": [
""500"",
""600"",
""700"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Lobster"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Yanone Kaffeesatz"",
""Weights"": [
""200"",
""300"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Noto Serif"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Arvo"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Poiret One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Nunito"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Bree Serif"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Merriweather Sans"",
""Weights"": [
""300"",
""700"",
""800"",
""300italic"",
""regular"",
""italic"",
""700italic"",
""800italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Poppins"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Alegreya Sans"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""800"",
""900"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Abel"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Josefin Sans"",
""Weights"": [
""100"",
""300"",
""600"",
""700"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Libre Baskerville"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Asap"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Exo 2"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Anton"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ubuntu Condensed"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Pacifico"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Archivo Narrow"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Crimson Text"",
""Weights"": [
""600"",
""700"",
""regular"",
""italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Candal"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Francois One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Varela Round"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Quicksand"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Play"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Shadows Into Light"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Vollkorn"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Signika"",
""Weights"": [
""300"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Passion One"",
""Weights"": [
""700"",
""900"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cuprum"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Orbitron"",
""Weights"": [
""500"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Questrial"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Karla"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Catamaran"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Maven Pro"",
""Weights"": [
""500"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Alegreya"",
""Weights"": [
""700"",
""900"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""PT Sans Caption"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Exo"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Dancing Script"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Amatic SC"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rokkitt"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Pathway Gothic One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rubik"",
""Weights"": [
""300"",
""500"",
""700"",
""900"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Abril Fatface"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Yellowtail"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Fira Sans"",
""Weights"": [
""300"",
""500"",
""700"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Architects Daughter"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hammersmith One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Patua One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Roboto Mono"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Righteous"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Monda"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cinzel"",
""Weights"": [
""700"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Crete Round"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""EB Garamond"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Noticia Text"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Kaushan Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sanchez"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Josefin Slab"",
""Weights"": [
""100"",
""300"",
""600"",
""700"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Acme"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Russo One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lobster Two"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Comfortaa"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ropa Sans"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""ABeeZee"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Quattrocento Sans"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Domine"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Pontano Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Gloria Hallelujah"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Chewy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Istok Web"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""News Cycle"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bangers"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""BenchNine"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Source Code Pro"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Alfa Slab One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Gudea"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Sigmar One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cantarell"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Oleo Script"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Courgette"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Armata"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Work Sans"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Archivo Black"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Coming Soon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Covered By Your Grace"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Old Standard TT"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Satisfy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Permanent Marker"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Voltaire"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Economica"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Tinos"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Varela"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cabin Condensed"",
""Weights"": [
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ruda"",
""Weights"": [
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Fredoka One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Quattrocento"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Source Serif Pro"",
""Weights"": [
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Didact Gothic"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Vidaloka"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Handlee"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Rock Salt"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Playfair Display SC"",
""Weights"": [
""700"",
""900"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Audiowide"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Kreon"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Droid Sans Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Sintony"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Philosopher"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Cookie"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bevan"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cardo"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Antic Slab"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Playball"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Volkhov"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Great Vibes"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Boogaloo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Glegoo"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Shadows Into Light Two"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Arapey"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Special Elite"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Changa One"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Days One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Actor"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Tangerine"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sorts Mill Goudy"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Cantata One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rambla"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Luckiest Guy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Kanit"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Nobile"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Amiri"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ek Mukta"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Marck Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Damion"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rajdhani"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Gentium Book Basic"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Bad Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Kalam"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Signika Negative"",
""Weights"": [
""300"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Paytone One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Squada One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Neuton"",
""Weights"": [
""200"",
""300"",
""700"",
""800"",
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Khula"",
""Weights"": [
""300"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Teko"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Copse"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Alex Brush"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Khand"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cambay"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Antic"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Amaranth"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Telex"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Molengo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Aldrich"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Scada"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Homenaje"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Sacramento"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Alice"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Homemade Apple"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Ultra"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Jura"",
""Weights"": [
""300"",
""500"",
""600"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Nothing You Could Do"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Viga"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Gentium Basic"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Average Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Electrolize"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Patrick Hand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Pinyon Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Fauna One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Enriqueta"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Cherry Cream Soda"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Chivo"",
""Weights"": [
""900"",
""regular"",
""italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Coda"",
""Weights"": [
""800"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Calligraffitti"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Alegreya Sans SC"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""800"",
""900"",
""100italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Fugaz One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Puritan"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Average"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Rancho"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Lusitana"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""PT Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Neucha"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Kameron"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Pragati Narrow"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Ubuntu Mono"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Adamina"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Share"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Sarala"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Hanuman"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Allura"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Marvel"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Doppio One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Allerta Stencil"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Prata"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Michroma"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Basic"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Black Ops One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""PT Serif Caption"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hind Siliguri"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Syncopate"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Unica One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Advent Pro"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hind Vadodara"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Niconne"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Julius Sans One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Just Another Hand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Allerta"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ceviche One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Carrois Gothic"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Convergence"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Walter Turncoat"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Freckle Face"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nixie One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Gochi Hand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Spinnaker"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bubblegum Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Parisienne"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Lustria"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Carme"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Marmelad"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Aclonica"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Arbutus Slab"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Cabin Sketch"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Marcellus"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Merienda One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Jockey One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Limelight"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Reenie Beanie"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sansita One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Radley"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Chelsea Market"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Overlock"",
""Weights"": [
""700"",
""900"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Goudy Bookletter 1911"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Merienda"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Contrail One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Waiting for the Sunrise"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Rochester"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Mate"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Fontdiner Swanky"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Alef"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Oranienbaum"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Montserrat Alternates"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cutive"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Magra"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Marcellus SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Carter One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rosario"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Yesteryear"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Grand Hotel"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Crafty Girls"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Port Lligat Slab"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Berkshire Swash"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Schoolbell"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Coustard"",
""Weights"": [
""900"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Annie Use Your Telescope"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Corben"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Pompiere"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Ovo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Six Caps"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Belleza"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sree Krushnadevaraya"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Quantico"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cairo"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Alegreya SC"",
""Weights"": [
""700"",
""900"",
""regular"",
""italic"",
""700italic"",
""900italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Halant"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Fira Mono"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Cousine"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""monospace"",
""Family"": ""Oxygen Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Fredericka the Great"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Press Start 2P"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Forum"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mako"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Leckerli One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Metrophobic"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Sue Ellen Francisco"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Italianno"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Yantramanav"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Londrina Solid"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Duru Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Inder"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Frijole"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Zeyada"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Trocchi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Monoton"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Graduate"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Petit Formal Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Kadwa"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Strait"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Gilda Display"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Allan"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Cinzel Decorative"",
""Weights"": [
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Racing Sans One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Fanwood Text"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Baumans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Clicker Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Gruppo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Mr Dafoe"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Caudex"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Lilita One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Capriola"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Tauri"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Tenor Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Slackey"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Lateef"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Anonymous Pro"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Short Stack"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lemon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Oleo Script Swash Caps"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Slabo 13px"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Brawler"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Aladin"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Anaheim"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mouse Memoirs"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Montez"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Martel"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Quando"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Denk One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Yeseva One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""The Girl Next Door"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Wire One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Finger Paint"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Unkempt"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Give You Glory"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Andika"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Caveat"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rufina"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Kotta One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Oregano"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Alike"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Fenix"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kelly Slab"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Judson"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Delius"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""NTR"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Cutive Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Love Ya Like A Sister"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Timmana"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bowlby One SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""UnifrakturMaguntia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Lekton"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Stardos Stencil"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Prosto One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""VT323"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Happy Monkey"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Itim"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""La Belle Aurore"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Palanquin"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Khmer"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Crushed"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Just Me Again Down Here"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Square"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Herr Von Muellerhoff"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Gravitas One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Concert One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Headland One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Megrim"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Bentham"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Orienta"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Karma"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell English"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Carrois Gothic SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell DW Pica"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Poly"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Arizonia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Andada"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lily Script One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Imprima"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Simonetta"",
""Weights"": [
""900"",
""regular"",
""italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Expletus Sans"",
""Weights"": [
""500"",
""600"",
""700"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Skranji"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Quintessential"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Shanti"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Qwigley"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Gafata"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""GFS Didot"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Holtwood One SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Gabriela"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Caesar Dressing"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Fjord One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Bilbo Swash Caps"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Knewave"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Loved by the King"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sniglet"",
""Weights"": [
""800"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rationale"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Tienne"",
""Weights"": [
""700"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Belgrano"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Over the Rainbow"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Shojumaru"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kranky"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Norican"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Averia Sans Libre"",
""Weights"": [
""300"",
""700"",
""300italic"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ramabhadra"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Salsa"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Podkova"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Martel Sans"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Ledger"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Patrick Hand SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Dorsa"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Stalemate"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Italiana"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Federo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Engagement"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Kristi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell English SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bowlby One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Mountains of Christmas"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Meddon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Dawning of a New Day"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Biryani"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Life Savers"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Montserrat Subrayada"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Geo"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Share Tech"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Delius Swash Caps"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Fondamento"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Voces"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Euphoria Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Seaweed Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Mr De Haviland"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sail"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Kite One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mallanna"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Vast Shadow"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Balthazar"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Nova Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Amethysta"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Junge"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Unna"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cambo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Metamorphous"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Cherry Swash"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Buenard"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Aguafina Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Medula One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Rouge Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Share Tech Mono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Raleway Dots"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cantora One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Mate SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Flamenco"",
""Weights"": [
""300"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Oldenburg"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Nokora"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""McLaren"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Maiden Orange"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Averia Serif Libre"",
""Weights"": [
""300"",
""700"",
""300italic"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Amarante"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Stint Ultra Condensed"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Condiment"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Eczar"",
""Weights"": [
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Sofia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Cedarville Cursive"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Gurajada"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell Double Pica"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Prociono"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Coda Caption"",
""Weights"": [
""800""
]
},
{
""Category"": ""display"",
""Family"": ""Milonga"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Codystar"",
""Weights"": [
""300"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell French Canon"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Poller One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Rye"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Stoke"",
""Weights"": [
""300"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Titan One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Revalia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Englebert"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Tulpen One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Ruthie"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Chau Philomene One"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Iceland"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Dynalight"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rosarivo"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Trirong"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Chicle"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Numans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Habibi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Inika"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Rammetto One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Krona One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Vibur"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Ruluko"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Creepster"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Artifika"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Swanky and Moo Moo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Angkor"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kavoon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Donegal One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Scheherazade"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Stint Ultra Expanded"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Averia Libre"",
""Weights"": [
""300"",
""700"",
""300italic"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Monofett"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Pattaya"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ruslan Display"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell Great Primer"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Text Me One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Wallpoet"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Battambang"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Paprika"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell Double Pica SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell DW Pica SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Prompt"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Sancreek"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mandali"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Ramaraja"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Offside"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Esteban"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Snippet"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Sunshiney"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Buda"",
""Weights"": [
""300""
]
},
{
""Category"": ""display"",
""Family"": ""Overlock SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell Great Primer SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Mrs Saint Delafield"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Trade Winds"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Linden Hill"",
""Weights"": [
""regular"",
""italic""
]
},
{
""Category"": ""serif"",
""Family"": ""IM Fell French Canon SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Delius Unicase"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Piedra"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Henny Penny"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Round"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Jaldi"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Bilbo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sonsie One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Heebo"",
""Weights"": [
""100"",
""300"",
""500"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Alike Angular"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Kurale"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Wendy One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""League Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Akronim"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Redressed"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Mystery Quest"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Cagliostro"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""New Rocker"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Galada"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Port Lligat Sans"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Suranna"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Elsie"",
""Weights"": [
""900"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rubik One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Suwannaphum"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Pirata One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Antic Didone"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Laila"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bigshot One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""MedievalSharp"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Asul"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ribeye"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sumana"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Germania One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Chonburi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Dr Sugiyama"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Glass Antiqua"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Della Respira"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Irish Grover"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Bubbler One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Sarpanch"",
""Weights"": [
""500"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Wellfleet"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Galindo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Assistant"",
""Weights"": [
""200"",
""300"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Content"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Jacques Francois"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Miniver"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Joti One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Slim"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""UnifrakturCook"",
""Weights"": [
""700""
]
},
{
""Category"": ""display"",
""Family"": ""Keania One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Peralta"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Chango"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Almendra"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Sarina"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rozha One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nosifer"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Julee"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Iceberg"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Griffy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Original Surfer"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Lovers Quarrel"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Croissant One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Trykker"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Caveat Brush"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Flat"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Monsieur La Doulaise"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Miltonian Tattoo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Diplomata"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Athiti"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""GFS Neohellenic"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Emilys Candy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Margarine"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kenia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Astloch"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Seymour One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Autour One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Atomic Age"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Modern Antiqua"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Harmattan"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Trochut"",
""Weights"": [
""700"",
""regular"",
""italic""
]
},
{
""Category"": ""display"",
""Family"": ""Purple Purse"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Petrona"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Smythe"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Snowburst One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bokor"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lalezar"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Meie Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sura"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Faster One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Spicy Rice"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Jolly Lodger"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Fresca"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ranchers"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Mirza"",
""Weights"": [
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Passero One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ribeye Marrow"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Warnes"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Montaga"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Aref Ruqaa"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Koulen"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Galdeano"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Vampiro One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Rakkas"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Katibeh"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lancelot"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Romanesco"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Oval"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Averia Gruesa Libre"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Freehand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Jacques Francois Shadow"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Eagle Lake"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Taprom"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Dekko"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant Garamond"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Fascinate"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Gorditas"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Elsie Swash Caps"",
""Weights"": [
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Asset"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Palanquin Dark"",
""Weights"": [
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Devonshire"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Vesper Libre"",
""Weights"": [
""500"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Macondo Swash Caps"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Londrina Outline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Londrina Shadow"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Felipa"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sofadi One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Jomhuria"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Amiko"",
""Weights"": [
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rum Raisin"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Miltonian"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Goblin One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Moul"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Londrina Sketch"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Cut"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bayon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Nova Script"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sirin Stencil"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Arya"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Geostar Fill"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rhodium Libre"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Butterfly Kids"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Libre Franklin"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""display"",
""Family"": ""Siemreap"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Preahvihear"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Combo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Gidugu"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ewert"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Smokum"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Underdog"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Mrs Sheppards"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Spirax"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Miss Fajardose"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Molle"",
""Weights"": [
""italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Princess Sofia"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Marko One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Arbutus"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Plaster"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Rubik Mono One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Aubrey"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bigelow Rules"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Metal Mania"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Metal"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Odor Mean Chey"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kdam Thmor"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Federant"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Almendra Display"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Geostar"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Eater"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Tenali Ramakrishna"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Bonbon"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Sevillana"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Supermercado One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Butcherman"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Erica One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Macondo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Amita"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Risque"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Secular One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Dhurjati"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Dangrek"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Pridi"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Almendra SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mitr"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""El Messiri"",
""Weights"": [
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Uncial Antiqua"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Mr Bedfort"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Chenla"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ranga"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Suravaram"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Emblema One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Maitree"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Tillana"",
""Weights"": [
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Stalinist One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Ruge Boogie"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Chela One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Diplomata SC"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Changa"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Jim Nightshade"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bungee"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Sahitya"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Amatica SC"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Taviraj"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""100italic"",
""200italic"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic"",
""900italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Suez One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Flavors"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Arima Madurai"",
""Weights"": [
""100"",
""200"",
""300"",
""500"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Moulpali"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Fascinate Inline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""monospace"",
""Family"": ""Space Mono"",
""Weights"": [
""700"",
""regular"",
""italic"",
""700italic""
]
},
{
""Category"": ""display"",
""Family"": ""Unlock"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Kantumruy"",
""Weights"": [
""300"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Sriracha"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bungee Inline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bungee Shade"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Fasthand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hind Madurai"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Fruktur"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Inknut Antiqua"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""800"",
""900"",
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Lakki Reddy"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant Infant"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""300italic"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Asar"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant SC"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mada"",
""Weights"": [
""300"",
""500"",
""900"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""David Libre"",
""Weights"": [
""500"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Mukta Vaani"",
""Weights"": [
""200"",
""300"",
""500"",
""600"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Hanalei"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Proza Libre"",
""Weights"": [
""500"",
""600"",
""700"",
""800"",
""regular"",
""italic"",
""500italic"",
""600italic"",
""700italic"",
""800italic""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant Upright"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Hanalei Fill"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Atma"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Scope One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Baloo"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Baloo Thambi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Reem Kufi"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Hind Guntur"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Miriam Libre"",
""Weights"": [
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Modak"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Farsan"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Lemonada"",
""Weights"": [
""300"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""BioRhyme"",
""Weights"": [
""200"",
""300"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Frank Ruhl Libre"",
""Weights"": [
""300"",
""500"",
""700"",
""900"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Shrikhand"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Coiny"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Yrsa"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Rasa"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Ravi Prakash"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Peddana"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Chathura"",
""Weights"": [
""100"",
""300"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""Cormorant Unicase"",
""Weights"": [
""300"",
""500"",
""600"",
""700"",
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Yatra One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Baloo Bhai"",
""Weights"": [
""regular""
]
},
{
""Category"": ""serif"",
""Family"": ""BioRhyme Expanded"",
""Weights"": [
""200"",
""300"",
""700"",
""800"",
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Pavanam"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bungee Hairline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""handwriting"",
""Family"": ""Kavivanar"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Mogra"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Baloo Da"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kumar One Outline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Bungee Outline"",
""Weights"": [
""regular""
]
},
{
""Category"": ""display"",
""Family"": ""Kumar One"",
""Weights"": [
""regular""
]
},
{
""Category"": ""sans-serif"",
""Family"": ""Meera Inimai"",
""Weights"": [
""regular""
]
}
]
";
    }
}
