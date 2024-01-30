

using Qita;

List<Qitalar> qitalars=new List<Qitalar>()
{
    new Qitalar(){Id = 1,Name = "Osiyo"},
    new Qitalar(){Id = 2,Name = "Yevropa"},
    new Qitalar(){Id = 3,Name = "Amerika"},
    new Qitalar(){Id = 4,Name = "Avstraliya"},
    new Qitalar(){Id = 5,Name = "Afrika"}
};

List<Davlatlar> davlatlars=new List<Davlatlar>()
{
    new Davlatlar(){Id = 1,Name = "O'zbekiston",davlatId = 1},
    new Davlatlar(){Id = 2,Name = "Qozog'iston",davlatId = 1},
    new Davlatlar(){Id = 3,Name = "Saudiya Arabistoni",davlatId = 1},
    new Davlatlar(){Id = 4,Name = "Janubiy Koreya",davlatId = 1},
    new Davlatlar(){Id = 5,Name = "Qirg'iziston",davlatId = 1},
    //------------------------------------------------------
    new Davlatlar(){Id = 6,Name = "Fransiya",davlatId = 2},
    new Davlatlar(){Id = 7,Name = "Germaniya",davlatId = 2},
    new Davlatlar(){Id = 8,Name = "Shveytsariya",davlatId = 2},
    new Davlatlar(){Id = 9,Name = "Rossiya",davlatId = 2},
    new Davlatlar(){Id = 10,Name = "Gretsiya",davlatId = 2},
    //-----------------------------------------------------
    new Davlatlar(){Id = 11,Name = "Kanada",davlatId = 3},
    new Davlatlar(){Id = 12,Name = "Angiliya",davlatId = 3},
    new Davlatlar(){Id = 13,Name = "Braziliya",davlatId = 3},
    new Davlatlar(){Id = 14,Name = "Argentina",davlatId = 3},
    new Davlatlar(){Id = 15,Name = "Urugvay",davlatId = 3},
    //---------------------------------------------------
    new Davlatlar(){Id = 16,Name = "Misr",davlatId = 4},
    new Davlatlar(){Id = 17,Name = "Liviya",davlatId = 4},
    new Davlatlar(){Id = 18,Name = "Marokash",davlatId = 4},
    new Davlatlar(){Id = 19,Name = "Keniya",davlatId = 4},
    new Davlatlar(){Id = 20,Name = "Uganda",davlatId = 4},
    //--------------------------------------------------------
    new Davlatlar(){Id = 21,Name = "Kanberra",davlatId = 5},
    new Davlatlar(){Id = 22,Name = "Adelaida",davlatId = 5},
    new Davlatlar(){Id = 23,Name = "Xobart",davlatId = 5},
    new Davlatlar(){Id = 24,Name = "Sidney",davlatId = 5},
    new Davlatlar(){Id = 25,Name = "Darvin",davlatId = 5}
};

List<Shaharlar> shaharlars=new List<Shaharlar>()
{
   
new Shaharlar(){Id =1,Name = "Toshkent",shaharId = 1},
  new Shaharlar(){Id = 2,Name = "Qashqadaryo",shaharId = 1},
  new Shaharlar(){Id =3,Name = "Samarqand",shaharId = 1},
  new Shaharlar(){Id = 4,Name = "Jizzax",shaharId = 1},
  new Shaharlar(){Id = 5,Name = "Surxandaryo",shaharId = 1},
  //------------------------------------------
  new Shaharlar(){Id =6,Name = "Oqmo'la",shaharId = 2},
  new Shaharlar(){Id = 7,Name = "Otbosa",shaharId = 2},
  new Shaharlar(){Id =8,Name = "Derjavinsk",shaharId = 2},
  new Shaharlar(){Id = 9,Name = "Yesil",shaharId = 2},
  new Shaharlar(){Id = 10,Name = " Yereymentau",shaharId = 10},
  //------------------------------------------
  new Shaharlar(){Id =11,Name = "Ad Daff",shaharId = 3},
  new Shaharlar(){Id = 12,Name = "Al Khaydar",shaharId = 3},
  new Shaharlar(){Id =13,Name = "Al-Jubayl",shaharId = 3},
  new Shaharlar(){Id = 14,Name = "Ar-Riyod",shaharId = 3},
  
  //------------------------------------------
  new Shaharlar(){Id =15,Name = "Seul",shaharId = 4},
  new Shaharlar(){Id = 16,Name = "Incheon",shaharId = 4},
  new Shaharlar(){Id =17,Name = "Busan",shaharId = 4},
 
  //------------------------------------------
  new Shaharlar(){Id =18,Name = "Baliqchi",shaharId = 5},
  new Shaharlar(){Id = 19,Name = "Botken",shaharId = 5},
  new Shaharlar(){Id =20,Name = "Bishkek",shaharId = 5},
  new Shaharlar(){Id = 21,Name = "Jalolobod",shaharId = 5},
  new Shaharlar(){Id = 22,Name = "Qadamjoy",shaharId = 5},
  //------------------------------------------
  new Shaharlar(){Id =23,Name = "Ain",shaharId = 6},
  new Shaharlar(){Id = 24,Name = " Aisne",shaharId = 6},
  new Shaharlar(){Id =25,Name = "Ardèche ",shaharId = 6},
  new Shaharlar(){Id = 26,Name = " Allier",shaharId = 6},
  new Shaharlar(){Id = 27,Name = " Bas-Rhin",shaharId = 6},
  //------------------------------------------
  new Shaharlar(){Id =28,Name = "Berlin",shaharId = 7},
  new Shaharlar(){Id = 29,Name = "Brandenburg",shaharId = 7},
  new Shaharlar(){Id =30,Name = "Bremen",shaharId = 7},
  new Shaharlar(){Id = 31,Name = "Hamburg",shaharId = 7},
  new Shaharlar(){Id = 32,Name = "Bavariya",shaharId = 7},
  //------------------------------------------
  new Shaharlar(){Id =33,Name = "Hedemora",shaharId = 8},
  new Shaharlar(){Id = 34,Name = "Gränna",shaharId = 8},
  new Shaharlar(){Id =35,Name = "Enköping",shaharId = 8},
  new Shaharlar(){Id = 36,Name = "Djursholm",shaharId = 8},
  new Shaharlar(){Id = 37,Name = "Bollnäs",shaharId = 8},
  //------------------------------------------
  new Shaharlar(){Id =38,Name = "Grayvoron",shaharId = 9},
  new Shaharlar(){Id = 39,Name = "Kubinka",shaharId = 9},
  new Shaharlar(){Id =40,Name = "Gvardeysk",shaharId = 9},
  new Shaharlar(){Id = 41,Name = "Magas",shaharId = 9},
  new Shaharlar(){Id = 42,Name = "Lyudinovo",shaharId = 9},
  //------------------------------------------
  new Shaharlar(){Id =43,Name = " Nikaia",shaharId = 10},
  new Shaharlar(){Id = 44,Name = "Kallithea",shaharId = 10},
  new Shaharlar(){Id =45,Name = "Peristeri",shaharId = 10},
  new Shaharlar(){Id = 46,Name = "Jizzax",shaharId = 10},
  new Shaharlar(){Id = 47,Name = "Hedemora",shaharId = 10},
  //------------------------------------------
  new Shaharlar(){Id =48,Name = "kdfjrijg",shaharId = 11},
  new Shaharlar(){Id = 49,Name = "fdfggn",shaharId = 11},
  new Shaharlar(){Id =50,Name = "frgrg",shaharId = 11},
  new Shaharlar(){Id = 51,Name = "rgg",shaharId = 11},
  new Shaharlar(){Id = 52,Name = "vfgrg",shaharId = 11},
  //------------------------------------------
  new Shaharlar(){Id =53,Name = "grgrg",shaharId = 12},
  new Shaharlar(){Id = 54,Name = "grg ",shaharId = 12},
  new Shaharlar(){Id =55,Name = "Didsbury ",shaharId = 12},
  new Shaharlar(){Id = 56,Name = "Alberta",shaharId = 12},
  new Shaharlar(){Id = 57,Name = "Devon",shaharId = 12},
  //------------------------------------------
  new Shaharlar(){Id =58,Name = "Belém",shaharId = 13},
  new Shaharlar(){Id = 59,Name = "Recife",shaharId = 13},
  new Shaharlar(){Id =60,Name = "Manaus",shaharId = 13},
  new Shaharlar(){Id = 61,Name = "Fortaleza",shaharId = 13},
  new Shaharlar(){Id = 62,Name = "Fortaleza",shaharId = 13},
  //------------------------------------------
  new Shaharlar(){Id =63,Name = "TORONTO",shaharId = 14},
  new Shaharlar(){Id = 64,Name = "OTTAVA",shaharId = 14},
  new Shaharlar(){Id =65,Name = "lc,vl",shaharId = 14},
  new Shaharlar(){Id = 66,Name = "lclvvc",shaharId = 14},
  new Shaharlar(){Id = 67,Name = "lcl  vv",shaharId = 14},
  //------------------------------------------
  new Shaharlar(){Id =68,Name = "dnfjef",shaharId = 15},
  new Shaharlar(){Id = 69,Name = "frggrg",shaharId = 15},
  new Shaharlar(){Id =70,Name = "dgrgrhg",shaharId = 15},
  new Shaharlar(){Id = 71,Name = "fgrgg",shaharId = 15},
  new Shaharlar(){Id = 72,Name = "grfrg",shaharId = 15},
  //------------------------------------------
  new Shaharlar(){Id =73,Name = "fgrhg",shaharId = 16},
  new Shaharlar(){Id = 74,Name = "dgrgh",shaharId = 16},
  new Shaharlar(){Id =75,Name = "dgrgh",shaharId = 16},
  new Shaharlar(){Id = 76,Name = "Jizzhyhax",shaharId = 16},
  new Shaharlar(){Id = 77,Name = "hyj",shaharId = 16},
  //------------------------------------------
  new Shaharlar(){Id =78,Name = "hthjhj",shaharId = 17},
  new Shaharlar(){Id = 79,Name = "Qashgthqadaryo",shaharId = 17},
  new Shaharlar(){Id =80,Name = "hth",shaharId = 17},
  new Shaharlar(){Id = 81,Name = "hth",shaharId = 17},
new Shaharlar(){Id = 82,Name = "hth",shaharId = 17},
  //------------------------------------------
  new Shaharlar(){Id =83,Name = "hth",shaharId = 18},
  new Shaharlar(){Id = 84,Name = "Qasjujhqadaryo",shaharId = 18},
  new Shaharlar(){Id =85,Name = "Samafgrhrqand",shaharId = 18},
  new Shaharlar(){Id = 86,Name = "grh",shaharId = 18},
  new Shaharlar(){Id = 87,Name = "fgrhr",shaharId = 18},
  //------------------------------------------
  new Shaharlar(){Id =88,Name = "fgrh5",shaharId = 19},
  new Shaharlar(){Id = 89,Name = "Qashqfhthadaryo",shaharId = 19},
  new Shaharlar(){Id =90,Name = "fhthth",shaharId = 19},
  new Shaharlar(){Id = 91,Name = "fhth",shaharId = 19},
  new Shaharlar(){Id = 92,Name = "fght",shaharId = 19},
  //------------------------------------------
  new Shaharlar(){Id =93,Name = "hth",shaharId = 20},
  new Shaharlar(){Id = 94,Name = "hth",shaharId = 20},
  new Shaharlar(){Id =95,Name = "fhthf",shaharId = 20},
  new Shaharlar(){Id = 96,Name = "gththizzax",shaharId = 20},
  new Shaharlar(){Id = 97,Name = "fhth",shaharId = 20},
  //------------------------------------------
  new Shaharlar(){Id =98,Name = "fhtht",shaharId = 21},
  new Shaharlar(){Id = 99,Name = "dfretg",shaharId = 21},
  new Shaharlar(){Id =100,Name = "dgrg",shaharId = 21},
  new Shaharlar(){Id = 101,Name = "dgr",shaharId = 21},
  new Shaharlar(){Id = 102,Name = "fgrr",shaharId = 21},
  //------------------------------------------
  new Shaharlar(){Id =103,Name = "rgrt",shaharId = 22},
  new Shaharlar(){Id = 104,Name = "dgrt",shaharId = 22},
  new Shaharlar(){Id =105,Name = "sfert",shaharId = 22},
  new Shaharlar(){Id = 106,Name = "drgr",shaharId = 22},
  new Shaharlar(){Id = 107,Name = "grhhj",shaharId = 22},
  //------------------------------------------
  new Shaharlar(){Id =108,Name = "grrr",shaharId = 23},
  new Shaharlar(){Id = 109,Name = "drge",shaharId = 23},
  new Shaharlar(){Id =110,Name = "dfrg",shaharId = 23},
  new Shaharlar(){Id = 111,Name = "fgrg",shaharId = 23},
  new Shaharlar(){Id = 112,Name = "fgr",shaharId = 23},
  //------------------------------------------
  new Shaharlar(){Id =113,Name = "grht",shaharId = 24},
  new Shaharlar(){Id = 114,Name = "hthh",shaharId = 24},
  new Shaharlar(){Id =115,Name = "hu6th",shaharId = 24},
  new Shaharlar(){Id = 116,Name = "ghthd",shaharId = 24},
  new Shaharlar(){Id = 117,Name = "thyju",shaharId = 24},
  //------------------------------------------
  new Shaharlar(){Id =118,Name = "ghth",shaharId = 25},
  new Shaharlar(){Id = 119,Name = "htht",shaharId = 25},
  new Shaharlar(){Id =120,Name = "ghth",shaharId = 25},
  new Shaharlar(){Id = 121,Name = "thtjj",shaharId = 25},
  new Shaharlar(){Id = 122,Name = "ght",shaharId = 25},
  //------------------------------------------
  new Shaharlar(){Id =123,Name = "Toshfhjkent",shaharId = 26},
  new Shaharlar(){Id = 124,Name = "ghyj",shaharId = 26},
  new Shaharlar(){Id =125,Name = "fhth",shaharId = 26},
  new Shaharlar(){Id = 126,Name = "fhtjt",shaharId = 26},
  new Shaharlar(){Id = 127 ,Name = "shyj",shaharId = 26}
};

var davlatwithshahar=davlatlars.GroupJoin(shaharlars,davlat=>davlat.Id,
    shahar=>shahar.shaharId,(davlat,shahar)=>new
    {
        davlat,
        shahar
    }).ToList();
    
    
    var qitawithdavlat=qitalars.GroupJoin(davlatwithshahar,qita=>qita.Id,
        davlat=>davlat.davlat.davlatId,(qita,davlat)=>new
        {
            qita,
            davlat
        }).ToList();



foreach (var i in qitawithdavlat)
{
    Console.WriteLine(i.qita.Id+"  "+i.qita.Name);
    foreach (var j in i.davlat)
    {
        Console.WriteLine($"\t\t {j.davlat.Id}  {j.davlat.Name}");
        foreach (var k in j.shahar)
        {
            Console.WriteLine($"\t\t\t{k.Id}  {k.Name} ");
        }
    }
}