<h1><b>My Personal Diary</b></h1>
Визуелно програмирање проект - Ирина Ристевска и Маја Милошеска

----
<h2> 1. Опис на апликацијата </h2> 

<p>Идејата на апликцијата е корисникот да може да запишува <i>белешки</i> подредени по датум кои ќе бидат приватни, заштитени со лозинка и само тој да може да ги прочита, променува и додава нови. Дополнително, имплементиран е текст-едитор со кој може да се форматиираат белешките</p>

<h2>  2. Упатство за користењe</h2> 

<h4>2.1 Креирање нов корисник и најава </h4> 
<p>При стартување на апликацијата се отвара <i>Log In</i> прозорец во кој треба да ги внесите вашето корисничко име и лозинка, и потоа да се најавите со кликнување на копчето Log In. Доколку немате креирано корисничка сметка, тогаш потребно е да притисните на копчето Sign Up, со што вашето корисничко име и лозинка ќе бидат додадени и понатаму ќе можете со истите да се најавите.</p>
<img height="400px" src="http://img.prntscr.com/img?url=http://i.imgur.com/gZpYjAM.png"/>

<h4>2.2 Главен прозорец</h4>
<p>Доколку прв пат се најавувате, во тој момент ви се креира бинарна датотека (.mpd file) со вашето корисничко име, во спротивно се десеријализира, односно ви се вчитуваат вашите претходно запишани податоци. На левата страна има место за вашата фотографија (која исто така се вчитува доколку претходно ја имате поставено), потоа календар, а под него листа со белешки за соодветно селектираниот датум. Во средината се наоѓа едиторот/прегледувачот за белешки кој се појавува при селектирање на веќе постоечка белешка од листата или креирање на нова. има алатки за уредување на текст. Дополнително имаме алатки за текст со кои можеме да го форматираме текстот од белешките. Десно горе имаме Save All, Log Out и +Entry.</p>

<img height="400px" src="http://img.prntscr.com/img?url=http://i.imgur.com/CkZWmvJ.png">

<h4>2.3 Начин на користење </h4>
<ul>
<li> <i>Креирање нова белешка</i>

<p>Со кликнување на копчето [+Entry] се отвара нова празна белешка со простор каде може да се внесе насловот и детали кои можат да се форматиираат преку избор на алатки (Bold, Italic, Underline, Font Color, Highlight, Change font, Change size) од лентата за алатки. Датата на која ќе биде оваа белешка меморирана може да се избере со клик на календарот на одреден датум, во спротивно се креира на моменталниот датум на вашиот компјутер.
</p> <img height="400" src="http://img.prntscr.com/img?url=http://i.imgur.com/4Gs7IZQ.png"><br></li>

<li><i>Привремено меморирање на белешка</i>

<p>Доколку сакаме новата белешка или онаа која сме ја едитирале <i>привремено</i> да ја меморираме во листата кликнуваме на копчето 
[ Save Entry ]. Дополнително, ова копче ја затвора белешката во едиторот. Промените направени ќе бидат присутни во текот на работењето, но не се запишани во бинарната датотека на корисникот.  </p></li>
<li><i>Разгледување и едитирање на белешки</i>

<p>Со кликнување на одреден датум на календарот во листата под него се прикажуваат белешките кои биле меморирани на тој датум. При избор на белешка (клик на нејзиниот наслов од листата), истата се прикажува во едиторот, но не е дозволено нејзино менување. Доколку сакаме да ја менуваме потребно е да кликнеме на копчето [ Edit Entry ] со што се овозможува менување како и привремено меморирање.</p>

</li>

<li><i>Бришење на белешки</i>
<p>Доколку е селектирана ставка од листата на белешки со клик на копчето [ Delete Entry ], белешката привремено се брише од листата.</p></li>
<li><i>Менување на фотографија</i>
<p>Со клик на иконата можеме да поставиме фотографија за корисничката сметка. Притоа се покажува Open Dialog од каде ја избираме патеката до сликата.</p></li>

<li><i>Меморирање на сите промени</i>
<p>Откако ќе направиме одредени промени можеме да кликнеме на копшето [ Save all ]. Со негово кликнување сите промени се меморираат во корисничката датотека. Доколку не ги меморирате вашите промени кликнете на [ Log out ], се појавува прозорец кој ќе ве предупреди дека доколку не ги зачувате ќе ги изгубите сите ваши промени од послендниот пат кога сте притиснале [ Save All ] до сега. </p></li>

<li><i>Log out</i>
<p>Со клик на копчето [ Log out ] излегувате од програмот доколку немате направено никакви промени.</p>
</li>

</ul>

<h2>  3. Претставување </h2> 

<h4>3.1 Структура на апликацијата </h4>

Оваа апликација е составена од класите ```Entry.cs``` и ```Document.cs``` со помош на кои се претставени главните податоци - белешките, класата  ```UserBaseController.cs``` со која се манипулира со XML базата на корисници, и двете форми ```LogIn.cs``` и ```UserDiary```. Секоја белешка (објект од класата Entry) e претставена на следниот начин:

```c#
[Serializable]
    class Entry
    {
        public string Title { get; set; } // Entry title
        public DateTime Date { get; set; } // When was the entry created
        public String Text { get; set; } // Formated text details of the entry
        public int ID { get; private set; } // Entry ID

        public void setEntry(string title, string txt, DateTime time)
        {
            Title = title;
            Text = txt;
            Date = time;
        }

        public Entry()
        {
            ID = new Random().Next();
        }

        public override string ToString() //How the entry will be shown in the UserDiary.cs list
        {
            return Title;
        }
    }
```

Секоја белешка има наслов, дата на која е креирана, текст и ID. Во атрибутот ```String Text``` не се чува обичен текст <i>(plain text)</i> туку <a href="https://en.wikipedia.org/wiki/Rich_Text_Format">RTF code</a> кој се зема од RichTextBox контролата во UserDiary формата. На тој начин освен што се меморира текстот кој го внесува корисникот се меморира и форматирањето кое го направил (боја, фонт и сл.).

<h4>3.2 Серијализација </h4>

Класите ```Entry.cs``` и ```Document.cs``` се серијализабилни , што овозможува сите внесени податоци, слики, текст, да биде зачувани. Во апликацијата користиме бинарна серијализација и единствен начин за десеријализирање е при најава, со што при самото лоадирање на формата ќе се десеријализира датотеката со вашето кориничко име. На тој начин ниту вие можете да ја отворите датотеката на друг корисник, ниту друг може да пристапи до вашата без да ја знае вашата лозинка. Серијализацијата се врши преку функцијата ```public void saveFile()``` додека десеријализацијата преку public ```public void openFile(string filename)```.

<h4>3.3 XML база на корисници </h4>

Во апликацијата е имплементирана едноставна XML база во која се чуваат податоци за корисникот (username, password, file). Сите функции поврзани со неа се наоѓаат во класата ```UserBaseController.cs```. XML фајлот кој се креира се манипулира со помош на објект од класата  ```XmlSerializer``` со чија помош се серијализира и десеријализира еден XML фајл.

```c#
	 public bool LogInUser(string username, string password) 
```
Функцијата LogInUser за дадени username и password пребарува низ XML фајлот дали тие постојат во табелата. Доколку тие постојат враќа ```true``` и дозволува корисникот да премине на формата ```UserDiary```. Во спротивно се испишува порака за грешка. 

```c#
	 public bool SignUpUser(string username, string password) 
```
Функцијата SignUpUser за дадени username и password пребарува низ XML фајлот дали тие постојат во табелата. Притоа доколку таков корисник веќе постои не дозволува креирање на дупликат корисник во базата и враќа ```false```.