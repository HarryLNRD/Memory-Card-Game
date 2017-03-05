using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MemoryDen
{
    public partial class Form1 : Form
    {
        //Auta ta 2 omjects aforoun diaforetikes klaseis 
        Leaderboard lead = new Leaderboard();//gia th deuterh forma h opoia legetai Leaderboard
        LeaderBoard f = new LeaderBoard();//gia thn klash LeaderBoard h opoia asxoleitai me thn apothikeush twn skor

        Game g = new Game();//Auto to object tha xrhsimopoihthei gia epikoinonoume me thn class Game h opoia tha einai shmantikh gia thn pragmatopoihsh tou paixnidiou 

        OpenFileDialog openFileDialog = new OpenFileDialog();//To object pou tha xrhsimopoihthei gia na boresei o xrhsths na ploigithei se fakelous kai na brei tis eikones pou thelei na balei stis kartes

        int[] cardstoclose = new int[24] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//autos o pinakas antiprosopeuei poses kartes exoun brei to zeugari tous (0 an oxi/1 an nai)
                                                                                                                    //Xarhs se auton ton pinaka meta apo kathe sygrish enos zeugariou kartwn tha kleinoun mono autes gia tis opoies den exei brethei to zeugari

        int firstpick = 24; //se autes tis metablhtes tha apothikeutoun oi arithmoi twn kartwn pou exoun epilektei prwth kai deuterh antistoixa 
        int secondpick = 24;//oi metablhtes san "default" exoun to 24 dioti prepei na exoun mia timh pou den yparxei san thesh sto pinaka cards ths klasshs Game

        int tries;//auth h mateblhth tha krataei tis prospatheies tou paikth
        int timerticks;//auth h metablhth tha krataei to xrono tou paixnidiou me to na metraei poses fores exei kanei tick o timer 3


        public void disablecards()//auth h synarthsh tha ebodisei ton paikth apo to na epileksei kapoia karta se sygekrimenes stigmes enw xrhsimopoiei thn efarmogh
        {
            pictureBox25.Enabled = false;
            pictureBox26.Enabled = false;
            pictureBox27.Enabled = false;
            pictureBox28.Enabled = false;
            pictureBox29.Enabled = false;
            pictureBox30.Enabled = false;
            pictureBox31.Enabled = false;
            pictureBox32.Enabled = false;
            pictureBox33.Enabled = false;
            pictureBox34.Enabled = false;
            pictureBox35.Enabled = false;
            pictureBox36.Enabled = false;
            pictureBox37.Enabled = false;
            pictureBox38.Enabled = false;
            pictureBox39.Enabled = false;
            pictureBox40.Enabled = false;
            pictureBox41.Enabled = false;
            pictureBox42.Enabled = false;
            pictureBox43.Enabled = false;
            pictureBox44.Enabled = false;
            pictureBox45.Enabled = false;
            pictureBox46.Enabled = false;
            pictureBox47.Enabled = false;
            pictureBox48.Enabled = false;

        }

        public void ShowAllCards()//auth apla deixnei oles tis kartes sto xrhsth 
        {
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
        }

        public void comparecards(int first, int second)//sygrish h opoia ginetai otan epilexthei h deuterh karta kai xoume pleon dyo kartes na sygrinoume
        {
            if ((first == 1 && second == 2) || (first == 2 && second == 1))//Bazw ena if statement gia kathe zeugari kartwn  pou tha ekanan "match"
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();//Kalw th synarthsh victory check meta apo kathe epityxeis "match" kartwn gt meta apo ena "match" tha teleiwsoun oi kartes kai tha exei teleiwsei o paikths 
            }
            else if ((first == 3 && second == 4) || (first == 4 && second == 3))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 5 && second == 6) || (first == 6 && second == 5))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 7 && second == 8) || (first == 8 && second == 7))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 9 && second == 10) || (first == 10 && second == 9))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 11 && second == 12) || (first == 12 && second == 11))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 13 && second == 14) || (first == 14 && second == 13))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 15 && second == 16) || (first == 16 && second == 15))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 17 && second == 18) || (first == 18 && second == 17))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 19 && second == 20) || (first == 20 && second == 19))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 21 && second == 22) || (first == 22 && second == 21))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else if ((first == 23 && second == 24) || (first == 24 && second == 23))
            {
                textBox1.Text = "The Player found a pair of Cards";
                cardstoclose[firstpick] = 1;
                cardstoclose[secondpick] = 1;
                victorycheck();
            }
            else//to else anaferetai sthn periptosh pou paikths anoiksei 2 kartes oi opoies den einai idies
            {
                textBox1.Text = "Unmatching Pair";//tha emfanizei mynhma lathous
                disablecards();//tha ebodizei ton paikth na aggiksei kapoia allh karta gia ligo(oso xrono thelei o timer 2 gia na kanei tick) o paikths tha boresei na ksana epileksei karta otan oi 2 pou brhke lathos kleisoun 
                button1.Enabled = false;//gia na apofeuxthoun mikrolathi ebodizw to paikth apo to na pathsei to koubi kai na ksanaksekinhsei th partida prin ksanakleisoun oi 2 kartes
                timer2.Enabled = true;//Ksekinaei o timer 2 o opoios metraei poso xrono tha menoun anoiktes oi 2 kartes
            }

            tries = tries + 1;//kathe fora pou ginetai sygrish metaksy dyo gyrismenwn kartwn to tries auksanetai

            firstpick = 24; //kanw reset tis metablhtes gia na boresoun na ksanaxrhsimopoihthoun 
            secondpick = 24;
        }


        public void closeallcards()//antitheta me auto pou leei to onoma ths h idia h synarthsh den kleinei OLES tis kartes alla kleinei mono autes gia tis opoies den exei brethei to zeugari tous
        {                          //to ama exei brethei to zeugari mias kartas h oxi to kseroume apo thn array cardstoclose
            if (cardstoclose[0] == 0)//ama h thesh mias akrtas sthn array einai 0 tote bainei mesa sto if kai ginontai ta ekshs:
            {
                pictureBox25.Visible = true;//1. h karta "Kleinei"
                pictureBox25.Enabled = true;//2. epistrefetai ston user h ikanothta na kanei click sthn karta
            }
            if (cardstoclose[1] == 0)
            {
                pictureBox26.Visible = true;
                pictureBox26.Enabled = true;
            }
            if (cardstoclose[2] == 0)
            {
                pictureBox27.Visible = true;
                pictureBox27.Enabled = true;
            }
            if (cardstoclose[3] == 0)
            {
                pictureBox28.Visible = true;
                pictureBox28.Enabled = true;
            }
            if (cardstoclose[4] == 0)
            {
                pictureBox29.Visible = true;
                pictureBox29.Enabled = true;
            }
            if (cardstoclose[5] == 0)
            {
                pictureBox30.Visible = true;
                pictureBox30.Enabled = true;
            }
            if (cardstoclose[6] == 0)
            {
                pictureBox31.Visible = true;
                pictureBox31.Enabled = true;
            }
            if (cardstoclose[7] == 0)
            {
                pictureBox32.Visible = true;
                pictureBox32.Enabled = true;
            }
            if (cardstoclose[8] == 0)
            {
                pictureBox33.Visible = true;
                pictureBox33.Enabled = true;
            }
            if (cardstoclose[9] == 0)
            {
                pictureBox34.Visible = true;
                pictureBox34.Enabled = true;
            }
            if (cardstoclose[10] == 0)
            {
                pictureBox35.Visible = true;
                pictureBox35.Enabled = true;
            }
            if (cardstoclose[11] == 0)
            {
                pictureBox36.Visible = true;
                pictureBox36.Enabled = true;
            }
            if (cardstoclose[12] == 0)
            {
                pictureBox37.Visible = true;
                pictureBox37.Enabled = true;
            }
            if (cardstoclose[13] == 0)
            {
                pictureBox38.Visible = true;
                pictureBox38.Enabled = true;
            }
            if (cardstoclose[14] == 0)
            {
                pictureBox39.Visible = true;
                pictureBox39.Enabled = true;
            }
            if (cardstoclose[15] == 0)
            {
                pictureBox40.Visible = true;
                pictureBox40.Enabled = true;
            }
            if (cardstoclose[16] == 0)
            {
                pictureBox41.Visible = true;
                pictureBox41.Enabled = true;
            }
            if (cardstoclose[17] == 0)
            {
                pictureBox42.Visible = true;
                pictureBox42.Enabled = true;
            }
            if (cardstoclose[18] == 0)
            {
                pictureBox43.Visible = true;
                pictureBox43.Enabled = true;
            }
            if (cardstoclose[19] == 0)
            {
                pictureBox44.Visible = true;
                pictureBox44.Enabled = true;
            }
            if (cardstoclose[20] == 0)
            {
                pictureBox45.Visible = true;
                pictureBox45.Enabled = true;
            }
            if (cardstoclose[21] == 0)
            {
                pictureBox46.Visible = true;
                pictureBox46.Enabled = true;
            }
            if (cardstoclose[22] == 0)
            {
                pictureBox47.Visible = true;
                pictureBox47.Enabled = true;
            }
            if (cardstoclose[23] == 0)
            {
                pictureBox48.Visible = true;
                pictureBox48.Enabled = true;
            }

            //kai auto ginetai gia kathe karta

        }

        public void victorycheck()//H victorycheck elenxei an o paikths nikhse meta apo kathe epityxeis sygrish kartwn pou ekane
        {
            //psaxnw thn array cardstoclose dioti an einai gemath me 1 xwris kanena 0 auto shmainei pws to paixnidi teleiwse
            int factor = 1;//h metablhth factor tha periexei to apotelesma ths anazhthshs sthn array (1 an ola einai 1/ 0 an yparxei toulaxiston ena mhdeniko)
            for (int i = 0; i <= 23; i++)//xrhsimopoiw epanalhpsh for gia na psaksw kathe thesh ths array cardstoclose
            {
                if (cardstoclose[i] == 0)//ama estw kai mia thesh einai 0 bainei sto if
                {
                    factor = 0;//to factor ginetai 0 gia na shmeiothei oti to paixnidi den teleiwse akoma
                    break;//apo th stigmh pou h anazhthsh sthn array psaxnei gia estw kai ena 0 den xreiazetai na thn psaksoume allo otan to broume opote stamataw thn epanalhpsh for
                }
            }

            if (factor == 1)//tsekarw an to factor einai 1 to opoio deixnei oti o paikths kerdise
            {
               
                timer3.Enabled = false;//to timer 3 to opoio metraei to xrono pou diarkei ena paixnidi stamataei kai etsi stamataei na auksanete h timh tou timerticks
                textBox1.Text = "You win! The player compared " + tries + " pairs of cards in " + (timerticks / 60) + "mins " + (timerticks % 60) + "sec";//to textbox tha bgalei mynhma pws o paikths kerdise
                // h metablith ticks periexei posa deuterolepta xreiastike o xrhsths gia na kerdisei opote ta metafrazw se lepta kai deuterolepta gia fenetai pio kompso
                f.InsertNewScore(textBox2.Text, tries, timerticks);//h synarthsh tha isagei to score tou paikth sta arrays ths classhs LeaderBoard
                //Dinontai 3 times sth synarthsh insertnewscore (Oti einai grammeno sto textbox me to label Name: sta settings/ Tis prospathies pou ekane o paikths gia na kerdisei/ ta deuterolepta pou ekane o paikths gia na nikisei) 
            }

        }


        public void resetcardstoclose()//auth h synarthsh kanei reset thn array cardtoclose kai kanei oles tis times ths 0 
        {                               //h synarthsh tha kaleite otan ksekinaei kainourgio paixnidi
            for (int i = 0; i <= 23; i++)
            {
                cardstoclose[i] = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//ginontai merika pragmata me to pou anoiksei h efarmogh
        {
            this.Size = new Size(598, 516);//Auto einai gia na krypsw ta settings otan tha ksekinisei h efarmogh

            f.CreateFile();//me auth th synarthsh dhmiourgw ton fakelo Leaderboard.txt an den yparxei
            f.FileToArrays();//Kai me th synarthsh FileToArrays fernw ta dedomena pou einai eidh mesa sto fakelo sto arrays ths classhs LeaderBoard

        }




        private void button1_Click(object sender, EventArgs e)//to koubi Play Ksekinaei ena kainourgio gyro tou paixnidiou otan patietai
        {
            g.Shuffle();//Epikoinwnei me thn classh Game gia na anakateusei thn array cards h opoia einai mia apeikonish tou trapeziou mas me ths kartes se array
            
            
            //textBox1.Text = "[" + g.Getcard(0) + "," + g.Getcard(1) + "," + g.Getcard(2) + "," + g.Getcard(3) + "," + g.Getcard(4) + "," + g.Getcard(5) + "," + g.Getcard(6) + "," + g.Getcard(7) + "," + g.Getcard(8) + "," + g.Getcard(9) + "," + g.Getcard(10) + "," + g.Getcard(11) + "," + g.Getcard(12) + "," + g.Getcard(13) + "," + g.Getcard(14) + "," + g.Getcard(15) + "," + g.Getcard(16) + "," + g.Getcard(17) + "," + g.Getcard(18) + "," + g.Getcard(19) + "," + g.Getcard(20) + "," + g.Getcard(21) + "," + g.Getcard(22) + "," + g.Getcard(23) + "]";
            //Auto to kommati xrhsimopoihthike gia logous elenxou den exei kapoia epiptosh sto kodika 
            //an bgaloume to slash sxoliou tote me to pou anakateuete h trapoula to textbox tha grapsei th katastash ths array cards ths classhs Game

            ShowAllCards();//deixnontai oles oi kartes sthn arxh tou paixnidiou dinontas ston paikth mia eukairia na dei pou briskontai prin kleisoun
            pictureBox1.Location = new Point(g.Getx(1), g.Gety(1));//allazw th thesh twn picturebox pou periexoun tis eikones symfwna me th thesh tous sthn array cards
            pictureBox2.Location = new Point(g.Getx(2), g.Gety(2));//me thn boitheia twn synarthsewn GetX kai Get y oi opoies dineis thn katallhlh syntetagmenh gia 
             pictureBox3.Location = new Point(g.Getx(3), g.Gety(3));//thn analogh timh ths array cards
            pictureBox4.Location = new Point(g.Getx(4), g.Gety(4));
            pictureBox5.Location = new Point(g.Getx(5), g.Gety(5));
            pictureBox6.Location = new Point(g.Getx(6), g.Gety(6));
            pictureBox7.Location = new Point(g.Getx(7), g.Gety(7));
            pictureBox8.Location = new Point(g.Getx(8), g.Gety(8));
            pictureBox9.Location = new Point(g.Getx(9), g.Gety(9));
            pictureBox10.Location = new Point(g.Getx(10), g.Gety(10));
            pictureBox11.Location = new Point(g.Getx(11), g.Gety(11));
            pictureBox12.Location = new Point(g.Getx(12), g.Gety(12));
            pictureBox13.Location = new Point(g.Getx(13), g.Gety(13));
            pictureBox14.Location = new Point(g.Getx(14), g.Gety(14));
            pictureBox15.Location = new Point(g.Getx(15), g.Gety(15));
            pictureBox16.Location = new Point(g.Getx(16), g.Gety(16));
            pictureBox17.Location = new Point(g.Getx(17), g.Gety(17));
            pictureBox18.Location = new Point(g.Getx(18), g.Gety(18));
            pictureBox19.Location = new Point(g.Getx(19), g.Gety(19));
            pictureBox20.Location = new Point(g.Getx(20), g.Gety(20));
            pictureBox21.Location = new Point(g.Getx(21), g.Gety(21));
            pictureBox22.Location = new Point(g.Getx(22), g.Gety(22));
            pictureBox23.Location = new Point(g.Getx(23), g.Gety(23));
            pictureBox24.Location = new Point(g.Getx(24), g.Gety(24));

            timer1.Enabled = true;//Ksekinaei to timer 1 to opoio shmatodotei to xrono pou exei o paikths na dei tis kartes prin kleisoun
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)//to timer1 dinei ston paikth 2 deuterolepta na dei tis kartes kai otan kanei tick kanei ta ekshs:
        {
            

            resetcardstoclose();//1. mhdenizei oles tis theseis ths cardstoclose kalontas th synarthsh resetcardstoclose
            closeallcards();//2. Kleinei oles tis kartes me th synarthsh closeallcards h opoia tha kanei akribos auto dioti oles oi theseis ths cardstoclose einai 0

            textBox1.Text = "Go";

            tries = 0;//edw ksekinaei enas gyros tou paixnidiou opote tha mhdenisw 
            timerticks = 0;//tis prospathies tou paikth kai ton xrono
            timer3.Enabled = true; //kai ksekinaw ton timer 3

            //Einai kalo na shmeiothei oti mexri twra oi kartes einai disabled wste na mhn tis pathsei o paikths prin ksekinhsei to paixnidi

            timer1.Enabled = false;//Stamataw ton timer1 apto na synexisei na kanei tick dioti mas eniaze mono ta 2 deuterolepta paushs pou mas prosfere
        }


        //Einai shmantiko na anaferoume oti oi kartes den gyrizoun gia na kryftoun oi eikones pou exoun.
        //Akribws panw apo th eikones pou ypotithete einai oi kartes eoxun topothetithei alles eikones pou anadeikneioun to pisw meros twn kartwn
        //Autes oi deyteres eikones einai Visible otan h karta einai "krymmenh" kai Invisible otan oi karta fenetai
        //Ta pictureBox1-24 einai oi kartes pou exoun ta sxedia pou prepei na teriaksoun kai briskontai apo katw. Pera apo to gegonos oti anakateuontai o xrhsths den 
        //kanei pragmatika click autes alla tis deutereuon kartes pou einai apo panw
        //Ta pictureBox25-48 einai oi deutereuon kartes kai briskontai panw apo tis eikones me ta sxedia pou prepei na teriaxtoun prokeimenou na ta krypsoun 



        private void pictureBox25_Click(object sender, EventArgs e)//Epomenos edw pernw ta event pou ginontai otan o paikths kanei click ena apo ta deutereuon pictureboxes
        {
            pictureBox25.Visible = false;//To deutereuon picturebox ginetai aorato opote fenetai to sxedio ths kartas apo katw
            pictureBox25.Enabled = false;//To deutereuon picturebox ginetai disabled gia na mhn borei o xrhsths na to pathsei deuterh fora
            if (firstpick == 24)//Gia na kserw se poia metablhth (firstpick h secondpick) tha balw thn timh ths kartas elenxw katarxas an h firstpick exei akoma th default timh ths
            {
                firstpick = 0;//an nai tote allazei h timh ths firstpick ston analogo arithmo symfwna me to picturebox pou patithike
                
                //textBox1.Text = "firstpick is " + firstpick + " ";
                //to panw kommati kodika xrhsimopoiithike gia logous elenxou kata thn kataskeuh tou kwdika kai exei parameinei gia na boresoun na ksanaginoun oi elenxoi an xreiastei
            }
            else
            {
                secondpick = 0;//an h firstpick exei eidh mia timh ektos ths default tote h timh tou picturebox paei sthn secondpick
                //textBox1.Text = "secondpick is " + secondpick + " "; 
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));//efoswn apekthse kai h secondpick mia timh kaleite h synarthsh comparecards sthn opoia dinw tis times pou yparxoun stis theseis firstpick kai secondpick ths array cards
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = false;
            pictureBox26.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 1;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 1;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = false;
            pictureBox27.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 2;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 2;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = false;
            pictureBox28.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 3;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 3;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = false;
            pictureBox29.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 4;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 4;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = false;
            pictureBox30.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 5;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 5;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Visible = false;
            pictureBox31.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 6;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 6;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = false;
            pictureBox32.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 7;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 7;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = false;
            pictureBox33.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 8;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 8;
               // textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Visible = false;
            pictureBox34.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 9;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 9;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = false;
            pictureBox35.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 10;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 10;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Visible = false;
            pictureBox36.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 11;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 11;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = false;
            pictureBox37.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 12;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 12;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox38.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 13;
               // textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 13;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
            pictureBox39.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 14;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 14;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox40.Visible = false;
            pictureBox40.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 15;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 15;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.Visible = false;
            pictureBox41.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 16;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 16;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.Visible = false;
            pictureBox42.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 17;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 17;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pictureBox43.Visible = false;
            pictureBox43.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 18;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 18;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.Visible = false;
            pictureBox44.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 19;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 19;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox45.Visible = false;
            pictureBox45.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 20;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 20;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.Visible = false;
            pictureBox46.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 21;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 21;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.Visible = false;
            pictureBox47.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 22;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 22;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox48.Visible = false;
            pictureBox48.Enabled = false;
            if (firstpick == 24)
            {
                firstpick = 23;
                //textBox1.Text = "firstpick is " + firstpick + " ";
            }
            else
            {
                secondpick = 23;
                //textBox1.Text = "secondpick is " + secondpick + " ";
                comparecards(g.Getcard(firstpick), g.Getcard(secondpick));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)//O timer 2 diarkei 1 deuterolepto kai dinei ligo xrono ston paikth na dei tis kartes pou anoikse kai den teriazan
        {
            closeallcards();//otan kanei tick o timer 2 kaleite h synarthsh closeallcards gia na kleisoun oi kartes pou einai na kleisoun
            button1.Enabled = true;//to koubi ginetai enabled opote o paikths borei na kanei restart to paixnidi afou ginei h sygrish
            timer2.Enabled = false;//kai stamatame ton timer 2 gt opws kai ton timer1 thelame mono to 1 deuterolepto paushs pou exei na prosferei
        }

        private void timer3_Tick(object sender, EventArgs e)//O timer 3 kanei tick kathe deuterolepto kai xrhsimopoihte gia na metrhsoume to xrono pou diarkei enas gyros tou paixnidiou
        {
            timerticks = timerticks + 1;//kathe fora pou kanei tick h metablhth timerticks auksanei kata 1 wste sto telos tou paixnidiou na exoume ta deuterolepta pou krathse
        }

        private void label1_Click(object sender, EventArgs e)//To label1 einai auto pou tha se odhghsei sta settings
        {
            //Settings label



            openFileDialog.Filter = "Bitmaps|*.bmp|jpegs|*.jpg|pngs|*.png";//Ftiaxnw to filter tou object gia to eidos fakelwn pou tha emfanizei otan anoiksei to open file window
            

            this.Size = new Size(730, 516);//h efarmogh allazei megethos gia na fanei ena section pou htan krymeno sto xrhsth prin 
            groupBox1.Visible = true;//Auto kanei ta settings Visible gia na borei o user nak anei tis allages pou thelei
            textBox1.Text = "Through the Settings panel change the images of the cards, your name or clear the scoreboard!";//Ena mynhma pou tha emfanizetai sto textbox otan anoigoun ta settings
            disablecards();//Oi kartes ginontai disabled opws kai to koubi Play wste na mhn borei o paikths na paizei enw leitourgoun ta Settings

            ShowAllCards();//Ta sxedia twn kartwn ginontai orata ston user gia na borei na blepei tis allages pou kanei se auta

            button1.Enabled = false;


        }

        private void label12_Click(object sender, EventArgs e)//To label 12 einai to X panw deksia sta settings kai o xrhsths to pataei gia na bgei apo ta settings
        {
            //quit settings
            this.Size = new Size(598, 516);//To megethos ths efarmoghs gyrnaei sto kanoniko
            groupBox1.Visible = false;//Ta settings ginontai aorata
            textBox1.Text = "";//To mynhma twn settings bgainei apo to Textbox
            button1.Enabled = true;//To koubi ksanaenergopoihte

            //Ama o paikths afhsei sth mesh ena paixnidi kai kanei click sta settings den borei na epistrepsei se auto. Prepei na ksekinhsei kainourgia partida
        }

        private void label2_Click(object sender, EventArgs e)//Ta parakatw Labels xrhsimopoiountai gia na allaksei o user ta sxedia pou exoun ta picturebox
        {
            //1st pair
            Image x;//dhmiourgoume mia metablhth typou Image gia na apothikeutei mesa h eikona apo to fakelo 
            if (openFileDialog.ShowDialog() == DialogResult.OK)//O kodikas tha bei sto if otan o xrhsths pathsei to OK sto open file window(To koubi borei na leei kai open)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);//Otan dialextei to arxeio eikonas apothikeuete sthn metablhth eikonas x
                pictureBox1.Image = x;//meta to periexomeno ths metablhths dinetai sto zeugari picturebox pou antiproswpeuei kathe label
                pictureBox2.Image = x;
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox3.Image = x;
                pictureBox4.Image = x;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox5.Image = x;
                pictureBox6.Image = x;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox7.Image = x;
                pictureBox8.Image = x;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox9.Image = x;
                pictureBox10.Image = x;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox11.Image = x;
                pictureBox12.Image = x;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox13.Image = x;
                pictureBox14.Image = x;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox15.Image = x;
                pictureBox16.Image = x;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox17.Image = x;
                pictureBox18.Image = x;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox19.Image = x;
                pictureBox20.Image = x;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox21.Image = x;
                pictureBox22.Image = x;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Image x;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = Bitmap.FromFile(openFileDialog.FileName);
                pictureBox23.Image = x;
                pictureBox24.Image = x;
            }
        }

        private void label5_Click(object sender, EventArgs e)//To label5 Xrhsimopoihte gia na anerethoun oles oi allages pou exei kanei o xrhsths
        {
            //reset images
            pictureBox1.Image = Image.FromFile("card1.png");//Poly apla gia kathe PictureBox dinw thn analogh eikona apo to fakelo bin/Debug
            pictureBox2.Image = Image.FromFile("card1.png");
            pictureBox3.Image = Image.FromFile("card2.png");
            pictureBox4.Image = Image.FromFile("card2.png");
            pictureBox5.Image = Image.FromFile("card3.png");
            pictureBox6.Image = Image.FromFile("card3.png");
            pictureBox7.Image = Image.FromFile("card4.png");
            pictureBox8.Image = Image.FromFile("card4.png");
            pictureBox9.Image = Image.FromFile("card5.png");
            pictureBox10.Image = Image.FromFile("card5.png");
            pictureBox11.Image = Image.FromFile("card6.png");
            pictureBox12.Image = Image.FromFile("card6.png");
            pictureBox13.Image = Image.FromFile("card7.png");
            pictureBox14.Image = Image.FromFile("card7.png");
            pictureBox15.Image = Image.FromFile("card8.png");
            pictureBox16.Image = Image.FromFile("card8.png");
            pictureBox17.Image = Image.FromFile("card9.png");
            pictureBox18.Image = Image.FromFile("card9.png");
            pictureBox19.Image = Image.FromFile("card10.png");
            pictureBox20.Image = Image.FromFile("card10.png");
            pictureBox21.Image = Image.FromFile("card11.png");
            pictureBox22.Image = Image.FromFile("card11.png");
            pictureBox23.Image = Image.FromFile("card12.png");
            pictureBox24.Image = Image.FromFile("card12.png");
        }

        private void label17_Click(object sender, EventArgs e)//To label17 einai to label pou grafei "Leaderboard" emfanizei to leaderboard otan to patas
        {
            //show Leaderboard
            
            lead.Show();//to leaderboard emfanizetai se mia deuterh forma
            
            lead.EmptyLeaderBoard();//Xrhsimopoioume to "lead" to object pou xrhsimopoioume gia epikoinonhsoume me th deuterh forma gia na thn emfanisoume
            for(int i = 0; i <= 9; i++)//xrhsimopoiontas epanalhpsh for stelnw sthn deuterh forma tis 10 prwtes times ths kathe array ths classhs LeaderBoard
            {
                lead.WritePlace(f.GetPlace(i));//h Synarthsh WritePlace anoiksei sthn deuterh forma Leaderboard kai xrhsimopoihtai gia na gapsei mia grammh sto Leaderboard
                                                //san eisodo dexetai mia grammh keimenou pou pernoume apo thn synarthsh GetPlace ths classhs LeaderBoard pou tha doume pio katw

            }
            
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //otan kleinei h efarmogh o fakelos LeaderBoard.txt lambanei ta stoixeia twn arrays pou exoun ta dedomena tou Leaderboard
            f.ArraysToFile();
        }

        private void button2_Click(object sender, EventArgs e)//To button 2 einai to maurokokkino koubi sta settings kai xrhsimopoihtai gia na diagrapsei teleiws ta apothikeumena score twn paiktwn ews twra 
        {

        
            f.ClearFile();//Xrhsimopoioume thn synarthsh ClearFile ths clashs LeaderBoard gia na diagrapsw ta score
        }
    }


    public class Game//H classh Game xrhsimopoihte gia na parasthsei mia pio psifiakh kai prosbasimh apeikonish tou paixnidiou. Einai ousiastika o skeletos tou paixnidiou
    {                //apo edw elenxoume an oi kartes pou sygrinontai einai idies, anakateuoumai th trapoula, blepoume pia karta brisketai pou klp
        int[] cards = new int[24] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };//H array cards einai mia apeikonish tou trapeziou mas me tis kartes
                                                                                                                            //Oi theseis ths array einai oi theseis pou boroun na briskontai ta xartia me seira diavasmatos
                                                                                                                            //Oi times ths array antiprosopeuoun ta picturebox pou periexoun ta sxedia
        Random zari = new Random();//Den  ginetai Anakatema ths array me tyxaio tropo xwris ena Random Object to opoio apofasisa na onomasw zari


        

        public void reshuffle(int[] texts)//Mia synarthsh h opoia xrhsimopoiei ton algorithmo Knuth Shuffle gia na anakateusei ta periexomena ths array
        {
            // Knuth shuffle algorithm apo Wikipedia
            for (int t = 0; t < texts.Length; t++)
            {
                int tmp = texts[t];
                int r = zari.Next(t, texts.Length);
                texts[t] = texts[r];
                texts[r] = tmp;
            }
        }


        public void Shuffle()//h synarthsh Shuffle Kalei thn reshuffle dinontas ths thn array cards ws eisodo
        {

            reshuffle(cards);
        }



        public int Getx(int c)//H Getx xrhsimopoihte gia brethei h syntetagmenh x pou prepei na parei to kathe picturebox afou ginei to anakatema. Pernei eisodo ton arithmo ths kartas pou psaxnoume sthn Array cards 
        {
            int x = 0;//h x einai h time h opoia tha ginei return
            int k = 24;//xrhsimopoihsa arithmo pou den borei na parei  to k mesa sthn epanalhpsh for
            for (int i = 0; i < 24; i++)//xrhsimopoiw epanalhpsh for gia na brw se poia thesh einai o arithmos tou pictureebox pou mou exei zitithei
            {
                if (cards[i] == c)
                {
                    k = i;//shmeiwnw thn thesh tou arithmou tou picturebox sthn array cards
                }
            }

            if (k == 0 || k == 6 || k == 12 || k == 18)//analoga me poia thesh exei o arithmos tou picturebox tou dinete h analogh synetagmenh x
            {
                x = 10;
            }
            else if (k == 1 || k == 7 || k == 13 || k == 19)
            {
                x = 110;
            }
            else if (k == 2 || k == 8 || k == 14 || k == 20)
            {
                x = 210;
            }
            else if (k == 3 || k == 9 || k == 15 || k == 21)
            {
                x = 310;
            }
            else if (k == 4 || k == 10 || k == 16 || k == 22)
            {
                x = 410;
            }
            else if (k == 5 || k == 11 || k == 17 || k == 23)
            {
                x = 510;
            }
            
            return x;//epistrefw thn timh x h opoia poia periexei thn synetagmenh x pou prepei na labei to picturebox
        }

        public int Gety(int c)//Analoga me thn Getx h Gety briskei th syntetagmenh y tou picturebox. 
        {
            int y = 0;//arxikopoiw thn metablhth
            int k = 24;//xrhsimopoihsa arithmo pou den borei na parei  to k mesa sthn epanalhpsh for
            for (int i = 0; i < 24; i++)
            {
                if (cards[i] == c)
                {
                    k = i;
                }
            }

            if (k == 0 || k == 1 || k == 2 || k == 3 || k == 4 || k == 5)
            {
                y = 20;
            }
            else if (k == 6 || k == 7 || k == 8 || k == 9 || k == 10 || k == 11)
            {
                y = 120;
            }
            else if (k == 12 || k == 13 || k == 14 || k == 15 || k == 16 || k == 17)
            {
                y = 220;
            }
            else if (k == 18 || k == 19 || k == 20 || k == 21 || k == 22 || k == 23)
            {
                y = 320;
            }
            else
            {
                y = 558;
            }

            return y;
        }

        

        public int Getcard(int i)// Auth h synarthsh xrhsimopoieitai gia na dwsei ton arithmo ths kartas pou brisketai sth thesh i
        {
            return cards[i];
        }




    }

    public class LeaderBoard//H Classh LeaderBoard xrhsimopoieitai gia na krataei h efarmogh tous top10 paiktes tou paixnidiou
    {                       //Exei 2 mesa apothikeushs: 1. tis Arrays oi opoies kratane oso h efarmogh einai anoikth
                                                      //2. ton Fakelo LeaderBoard.txt o opoios xrhsimeuei wste na menoun ta score kai afou kleisei h efarmogh kai anoiksei mia argoterh hmeromhnia

        //Oi arrays ths Leaderboard einai 3 kai periexoun ta Onomata, Ta zeugaria pou xreiastike o paikths gia na kerdisei, Kai to xrono pou peire gia na to kanei 
        string[] Names = new String[11] { "", "", "", "", "", "", "", "", "", "", "" };
        int[] Tries = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] Time = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //Arxika ta arrays den periexoun tipota mono kena kai mhden


        public void CreateFile()
        {
            StreamWriter f = new StreamWriter("LeaderBoard.txt", true);
            f.Close();


            //Giati yparxei auto? 
            //To streamwriter tha dhmiourghsei to fakelo sto debug an den yparxei an yparxei eidh omws enas fakelos me to
            //onoma Leaderboard.txt den tha peiraksei auton kai ta periexomena tou. (Auto xarhs to true)

        }

        public void FileToArrays()//H synarthsh FileToArrays Tha parei ta 10 prwta stoixeia apo kathe Array kai tha ta apothikeusei ston fakelo LeaderBoard.txt
        {
            StreamReader reader = new StreamReader("LeaderBoard.txt");//dhmiourgoume StreamReader Object
            int i = 0;//arxikopoioume to i to opoio tha xrhsimopoihsoume gia na ploigithoume mesa apo tis Arrays kata th diarkeia ths epanalhpshs while pou akolouthei
            while (!reader.EndOfStream)//H epanalhpsh While tha ginetai mexri na teleiwsoun oi grammes pou exei na diavasei o reader sto fakelo txt
            {
                Names[i] = reader.ReadLine();//kathe fora pou dinetai auto to command aneksarthta apo to se pia epanalhpsh eimaste auto tha diavazei thn epomenh grammh 
                Tries[i] = int.Parse(reader.ReadLine());//etsi sto fakelo text ta stoixeia einai grammena kapos etsi: Giannhs
                Time[i] = int.Parse(reader.ReadLine());                                                             //56  
                i++;                                                                                                //125
            }                                                                                                       //Kwstas
                                                                                                                    //45
                                                                                                                    //79
            reader.Close();//kleinw ton Reader gt panta prepei na kelinoume objects pou diadrazontai me arxeia

            OrganiseArrays();//H synarthsh OrganiseArrays kaleite sto telos ths metaforas apo to fakelo stis Arrays gia na stixisei ta sotixeia se fthinousa seira
        }

        public void InsertNewScore(string name, int tries, int time)//H synarthsh auth xrhsimeuei gia na Iselthei stis Arrays ena kainourgio score
        {

            //Oi arrays xrhsimopoiountai gia na parousiasoun tis top 10 kalhteres prospathies omws exoun 11 theseis h kathe mia
            //H 11h thesh xrhsimopoieitai gia na eiselthetai ena kainourgio stoixeio amesws xwris na xreiazetai na sygrithei me oles tis times twn arrays
            //To stoixeio apla iselthetai sthn 11h thesh, Ginetai Stixish se fthinousa seira apo thn OrganiseArrays() kai sto telos ths OrganiseArrays() h 11h thesh katharizei dioxnontas ton ligotero ikano paikth apo tous top10 
            Names[10] = name;
            Tries[10] = tries;
            Time[10] = time;
            OrganiseArrays();
        }

        public void OrganiseArrays()//H synarthsh pou xrhsimopoihtai gia na paramenoun oi arrays se fthinousa seira
        {
            //Ena paikths theoreitai kalhteros apo ton allon ama xreiasthke ligoteres prospatheies apo auton gia na kerdisei
            //An 2 paiktes exoun ton idio arithmo prospatheiwn tote o kalhteros krinetai apo ton xrono pou xreiasthke


            //xrhsimopoiw thn gnwsth synarthsh Bubble sort gia na stisw ta dedomena twn arrays se fthinousa seira
            int temp = 0;//Xrhsimopoiw 2 eidwn temp ta opoia einai aparaithta gia na kanw swap sygkekrimenes times stis Arrays kata th diarkei tou bubble sort 
            string temp2 = "";

            for (int i = 0; i < Tries.Length; i++)
            {
                for (int j = 0; j < Tries.Length - 1; j++)
                {
                    if (((Tries[j] > Tries[j + 1]) && !(Tries[j + 1] == 0)) || (Tries[j] == 0))//Epipleon oroi sth sygrish tou if gia to bubble sort dioti san default se mia thesh h array tries exei 0 pou einai o pio mikros arithmos pou borei na exei
                    {
                        temp = Tries[j + 1];
                        Tries[j + 1] = Tries[j];
                        Tries[j] = temp;

                        temp = Time[j + 1];
                        Time[j + 1] = Time[j];
                        Time[j] = temp;

                        temp2 = Names[j + 1];
                        Names[j + 1] = Names[j];
                        Names[j] = temp2;


                    }
                    else if ((Tries[j] == Tries[j + 1]) && (Time[j] > Time[j + 1]))//+ oi oroi gia otan Oi prospathies enos paikth einai ises me autes tou deuterou
                    {
                        temp = Tries[j + 1];
                        Tries[j + 1] = Tries[j];
                        Tries[j] = temp;

                        temp = Time[j + 1];
                        Time[j + 1] = Time[j];
                        Time[j] = temp;

                        temp2 = Names[j + 1];
                        Names[j + 1] = Names[j];
                        Names[j] = temp2;
                    }

                }

            }

            Names[10] = "";//sto telos ths synarthshs auth katharizetai ta stoixeia ths 11hs theshs stis Arrays.
            Time[10] = 0;
            Tries[10] = 0;
        }

        public void ArraysToFile()//Auth h synarthsh metaferei ta stoixeia pou periexoun oi arrays sto fakelo LeaderBoard.txt
        {
            StreamWriter writer = new StreamWriter("LeaderBoard.txt");//dhmiourgw streamwriter project
            for (int i = 0; i < 10; i++)//Xrhsimopoiw epanalhpsh for gia na metaferw ta stoixeia sto txr arxeio
            {
                writer.WriteLine(Names[i]);
                writer.WriteLine(Tries[i] + "");
                writer.WriteLine(Time[i] + "");
            }
            writer.Close();//kleinw to writer
        }

        public void ClearFile()//Katharizw ta score apo pantou. (txt arxeio kai arrays)
        {
            StreamWriter writer = new StreamWriter("LeaderBoard.txt");
            
            writer.WriteLine("");
                
            
            writer.Close();

            //^ auto to kommati xrhsimopoihtai gia na katharistei to txt arxeio
            //v auto to kommati xr

            for(int i = 0; i <= 10; i++)
            {
                Names[i] = "";
                Tries[i] = 0;
                Time[i] = 0;
            }

        }

        public string GetName(int p)
        {
            return Names[p];
        }
        public int GetTries(int p)
        {
            return Tries[p];
        }
        public int GetTime(int p)
        {
            return Time[p];
        }
        //Den xrhsimopoiountai oles apo tis parapanw synarthseis alla egrapsa mia gia thn kathe Array se periptosh pou xreiastoun

        public string GetPlace(int p)//H synarthsh Get place lambanei th thesh sto Leaderboard gia thn opoia tha epistrepsei mia grammh string h opoia tha grafei "Onoma Prospathies Lepta Deuterolepta"
        {

            if (GetTries(p) == 0)//An h Tries array exei 0 sthn thesh p tote den yparxei kapoio score sth thesh p
            {
                return "";//ara gyrnaei keno
            }
            else
            {
                return Names[p] + " " + Tries[p] + " " + (Time[p]/60) + "Mns " + (Time[p] % 60) + "Scnds \r\n";
            }

        }

    }
}

