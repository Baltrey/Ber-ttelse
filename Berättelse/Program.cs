
//start av spelet
Console.WriteLine("Hej, Välkommen till Mitt super roliga spelXD");

//art på koyori
string koyori = @"                                                                            

                                                                                

                                                                                

               .=..                                             .=              
               ( >   \=.       .=   \.                     .==  + (             
               ( + .      \>.. ./ .==+).====.       ..===     . + )             
               (  +=+     ..+ /==-  \=/> -<\    \/(            +  (             
               )   /    .= =(/            =     -..  .            (             
                )/.  .  =                    .      .   =  /  \  )              
                 \ +(       >    /          )         .  (     = /              
                 )/./       )   .            \>        \   \ ( .(               
                 / /   .     \                +   .           +.(               
                 (/                           /              ++(                
                 )    )        )            \             ) \  )                
              )(/              )     )      +              ++ >==.              
             <( /              /-          +++.            )/     )             
            (  (      )\      (+>      .   +  +             (  =-/  (           
            (/)/        .     + )      )+ /       . >       (-=    .)           
            )-)        \ = \ )   )                (         )/  /+ )            
            )/)         ))()((())< \)>  \ >//////>>/         >   ))=            
              )       .  \\ +  \ )      + \  \ \( /          >+.+/(             
              (        )=. +             -               +   \( \()\            
              (        ).            ..  .      / .-/.  +          \ >          
              (/.    .   )=.                    ./     +    )      )  \         
              )(\\.  \.+.    /\==..........==(\.    .+   /  /       )  \        
            ./(\.\.\+=.\/=+.. \.  /( \))())\.+...+(  .=  / /         \          
       \(   .    \/>   \+=   ( ./)(/   )=)++\\+       .+  /            )=       
         \==(         +....).\/ /  / /   (  . (+\/      /\               )      
             \-        \...+)( (  (.+    (./  )+  )/                     /    ";
//art på rip
string rip = @"        
        _.---,._,'
       /' _.--.<
         /'     `'
       /' _.---._____
       \.'   ___, .-'`
           /'    \\             .
         /'       `-.          -|-
        |                       |
        |                   .-'~~~`-.
        |                 .'         `.
        |                 |  R  I  P  |
        |                 |           |
        |                 |           |
         \              \\|           |//
   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
while (true)
{
    //första testet
    Console.WriteLine("skriv in 1 för att fortsätta");
    if (Console.ReadLine() == "1")
    {
        Console.WriteLine("Du står vid ett övergångsställe hur vill då gå över");
        Thread.Sleep(1000);
        Console.WriteLine("1 Du går över");
        Thread.Sleep(1000);
        Console.WriteLine("2 Du kollar din omgivning");
        Thread.Sleep(1000);
        Console.WriteLine("3 Du hoppar över");
        string gata = Console.ReadLine();
        if (gata == "1")
        {
            Console.WriteLine("Du gick över men en lastbil åkte i full hastighet och du dog!!!");
            Thread.Sleep(1000);
            Console.WriteLine(rip);
        }
        if (gata == "2")
        {
            Console.WriteLine("Du kollar i din omgivning och ser att rödlyset är rött och bilar åker i full hastighet");
            Thread.Sleep(1000);
            Console.WriteLine("Vill du vänta tills det är grönt?");
            Thread.Sleep(1000);
            Console.WriteLine("1 Ja");
            Thread.Sleep(1000);
            Console.WriteLine("2 nej");
            Thread.Sleep(1000);
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Du ser en park vill du gå till den?");
                Thread.Sleep(1000);
                Console.WriteLine("1 ja");
                Thread.Sleep(1000);
                Console.WriteLine("2 nej");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Du går till parken");
                    Thread.Sleep(1000);
                    Console.WriteLine("I parken ser du Koyori!!!");
                    Thread.Sleep(1000);
                    Console.WriteLine(koyori);
                }
                else
                {
                    Console.WriteLine("okej tråkmåns");
                    Console.WriteLine("Du står och kollar på gatan med bilar gud vad roligt!!!");
                }
            }
            else
            {
                Console.WriteLine("Du gick över men en lastbil åkte i full hastighet och du dog!!!");
                Thread.Sleep(1000);
                Console.WriteLine(rip);
            }
        }
        else
        {
            Console.WriteLine("Hur trodde du att det skulle gå???");
            Thread.Sleep(1000);
            Console.WriteLine("Du hoppar ut i gatan med bilar som går i full hastighet och blir påkörd!!!");
            Thread.Sleep(1000);
            Console.WriteLine(rip);
        }

    }
    else
    {
        Console.WriteLine("haha så rolig spelet är nu över");
    }
    Console.WriteLine("Vill du köra igen? [Y or N]");

    bool toContinue = false;
    bool invalidResponse = true;

    while (invalidResponse)
    {
        // få svar
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            toContinue = true;
            invalidResponse = false;
        }
        else if (answer == "N")
        {
            invalidResponse = false;
        }
    }

    if (toContinue != true) return;
}


