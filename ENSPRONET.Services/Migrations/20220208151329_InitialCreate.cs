using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENSPRONET.Services.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    Alpha2Code = table.Column<string>(type: "TEXT", nullable: false),
                    Alpha3Code = table.Column<string>(type: "TEXT", nullable: false),
                    NumericCode = table.Column<int>(type: "INTEGER", nullable: false),
                    SubDivisionCode = table.Column<string>(type: "TEXT", nullable: true),
                    InternetDomain = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 101, "KZ", "KAZ", "Kazakhstan", ".kz", 398, "KZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 102, "SM", "SMR", "San Marino", ".sm", 674, "SM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 103, "GL", "GRL", "Greenland", ".gl", 304, "GL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 104, "KH", "KHM", "Cambodia", ".kh", 116, "CB" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 105, "LB", "LBN", "Lebanon", ".lb", 422, "LE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 106, "BG", "BGR", "Bulgaria", ".bg", 100, "BU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 107, "CH", "CHE", "Switzerland", ".ch", 756, "SZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 108, "MX", "MEX", "Mexico", ".mx", 484, "MX" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 109, "GH", "GHA", "Ghana", ".gh", 288, "GH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 110, "MA", "MAR", "Morocco", ".ma", 504, "MO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 111, "CO", "COL", "Colombia", ".co", 170, "CO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 112, "IQ", "IRQ", "Iraq", ".iq", 368, "IZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 113, "US", "USA", "United States", ".us", 840, "US" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 114, "NF", "NFK", "Norfolk Island", ".nf", 574, "NF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 115, "UZ", "UZB", "Uzbekistan", ".uz", 860, "UZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 116, "MT", "MLT", "Malta", ".mt", 470, "MT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 117, "NP", "NPL", "Nepal", ".np", 524, "NP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 118, "NG", "NGA", "Nigeria", ".ng", 566, "NI" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 119, "AO", "AGO", "Angola", ".ao", 24, "AO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 120, "AM", "ARM", "Armenia", ".am", 51, "AM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 121, "CY", "CYP", "Cyprus", ".cy", 196, "CY" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 122, "CD", "COD", "Democratic Republic of the Congo", ".cd", 180, "CG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 123, "ET", "ETH", "Ethiopia", ".et", 231, "ET" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 124, "MA", "MAR", "Morocco", ".ma", 504, "MO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 125, "TF", "ATF", "French Southern Territories", ".tf", 260, "FS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 126, "BW", "BWA", "Botswana", ".bw", 72, "BC" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 127, "SC", "SYC", "Seychelles", ".sc", 690, "SE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 128, "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 129, "JE", "JEY", "Jersey", ".je", 832, "JE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 130, "TM", "TKM", "Turkmenistan", ".tm", 795, "TX" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 131, "HT", "HTI", "Haiti", ".ht", 332, "HA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 132, "BT", "BTN", "Bhutan", ".bt", 64, "BT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 133, "CM", "CMR", "Cameroon", ".cm", 120, "CM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 134, "AW", "ABW", "Aruba", ".aw", 533, "AA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 135, "AX", "ALA", "Aland Islands", ".ax", 248, "" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 136, "EC", "ECU", "Ecuador", ".ec", 218, "EC" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 137, "GG", "GGY", "Guernsey", ".gg", 831, "GK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 138, "TD", "TCD", "Chad", ".td", 148, "CD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 139, "GN", "GIN", "Guinea", ".gn", 324, "GV" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 140, "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 141, "FM", "FSM", "Micronesia", ".fm", 583, "FM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 142, "AL", "ALB", "Albania", ".al", 8, "AL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 143, "LT", "LTU", "Lithuania", ".lt", 440, "LH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 144, "MN", "MNG", "Mongolia", ".mn", 496, "MG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 145, "BH", "BHR", "Bahrain", ".bh", 48, "BA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 146, "CC", "CCK", "Cocos Islands", ".cc", 166, "CK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 147, "MS", "MSR", "Montserrat", ".ms", 500, "MH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 148, "BO", "BOL", "Bolivia", ".bo", 68, "BL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 149, "GM", "GMB", "Gambia", ".gm", 270, "GA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 150, "CV", "CPV", "Cabo Verde", ".cv", 132, "CV" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 151, "FO", "FRO", "Faroe Islands", ".fo", 234, "FO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 152, "MP", "MNP", "Northern Mariana Islands", ".mp", 580, "CQ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 153, "LV", "LVA", "Latvia", ".lv", 428, "LG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 154, "SZ", "SWZ", "Eswatini", ".sz", 748, "WZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 155, "GM", "GMB", "Gambia", ".gm", 270, "GA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 156, "JM", "JAM", "Jamaica", ".jm", 388, "JM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 157, "TF", "ATF", "French Southern Territories", ".tf", 260, "FS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 158, "BS", "BHS", "Bahamas", ".bs", 44, "BF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 159, "PW", "PLW", "Palau", ".pw", 585, "PS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 160, "LT", "LTU", "Lithuania", ".lt", 440, "LH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 161, "BO", "BOL", "Bolivia", ".bo", 68, "BL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 162, "DZ", "DZA", "Algeria", ".dz", 12, "AG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 163, "ES", "ESP", "Spain", ".es", 724, "SP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 164, "BI", "BDI", "Burundi", ".bi", 108, "BY" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 165, "TD", "TCD", "Chad", ".td", 148, "CD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 166, "AN", "ANT", "Netherlands Antilles", ".an", 530, "NT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 167, "KN", "KNA", "Saint Kitts and Nevis", ".kn", 659, "SC" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 168, "MS", "MSR", "Montserrat", ".ms", 500, "MH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 169, "YE", "YEM", "Yemen", ".ye", 887, "YM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 170, "KE", "KEN", "Kenya", ".ke", 404, "KE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 171, "CO", "COL", "Colombia", ".co", 170, "CO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 172, "BO", "BOL", "Bolivia", ".bo", 68, "BL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 173, "MS", "MSR", "Montserrat", ".ms", 500, "MH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 174, "IR", "IRN", "Iran", ".ir", 364, "IR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 175, "MM", "MMR", "Myanmar", ".mm", 104, "BM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 176, "PY", "PRY", "Paraguay", ".py", 600, "PA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 177, "UZ", "UZB", "Uzbekistan", ".uz", 860, "UZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 178, "TK", "TKL", "Tokelau", ".tk", 772, "TL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 179, "PL", "POL", "Poland", ".pl", 616, "PL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 180, "AU", "AUS", "Australia", ".au", 36, "AS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 181, "GG", "GGY", "Guernsey", ".gg", 831, "GK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 182, "VI", "VIR", "U.S. Virgin Islands", ".vi", 850, "VQ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 183, "GL", "GRL", "Greenland", ".gl", 304, "GL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 184, "PF", "PYF", "French Polynesia", ".pf", 258, "FP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 185, "NA", "NAM", "Namibia", ".na", 516, "WA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 186, "SC", "SYC", "Seychelles", ".sc", 690, "SE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 187, "TR", "TUR", "Turkey", ".tr", 792, "TU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 188, "BV", "BVT", "Bouvet Island", ".bv", 74, "BV" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 189, "TO", "TON", "Tonga", ".to", 776, "TN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 190, "KR", "KOR", "South Korea", ".kr", 410, "KS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 191, "HT", "HTI", "Haiti", ".ht", 332, "HA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 192, "GH", "GHA", "Ghana", ".gh", 288, "GH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 193, "GG", "GGY", "Guernsey", ".gg", 831, "GK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 194, "CD", "COD", "Democratic Republic of the Congo", ".cd", 180, "CG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 195, "JO", "JOR", "Jordan", ".jo", 400, "JO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 196, "CG", "COG", "Republic of the Congo", ".cg", 178, "CF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 197, "LK", "LKA", "Sri Lanka", ".lk", 144, "CE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 198, "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 199, "MT", "MLT", "Malta", ".mt", 470, "MT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 200, "CZ", "CZE", "Czechia", ".cz", 203, "EZ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
