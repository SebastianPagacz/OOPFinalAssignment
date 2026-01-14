namespace RpgCombat.Core;

public class ConsoleLogger
{
    public void WriteLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[BATTLE_LOG]: {message}");
    }

    public void RenderStartScreen()
    {
        Console.Write(@"
                                                                                  
            ,----..       ,----..   ,-.----.                      ,-.----.                
           /   /   \     /   /   \  \    /  \          ,-.----.   \    /  \    ,----..    
          /   .     :   /   .     : |   :    \         \    /  \  |   :    \  /   /   \   
         .   /   ;.  \ .   /   ;.  \|   |  .\ :        ;   :    \ |   |  .\ :|   :     :  
        .   ;   /  ` ;.   ;   /  ` ;.   :  |: |        |   | .\ : .   :  |: |.   |  ;. /  
        ;   |  ; \ ; |;   |  ; \ ; ||   |   \ :        .   : |: | |   |   \ :.   ; /--`   
        |   :  | ; | '|   :  | ; | '|   : .   /        |   |  \ : |   : .   /;   | ;  __  
        .   |  ' ' ' :.   |  ' ' ' :;   | |`-'         |   : .  / ;   | |`-' |   : |.' .' 
        '   ;  \; /  |'   ;  \; /  ||   | ;            ;   | |  \ |   | ;    .   | '_.' : 
         \   \  ',  /  \   \  ',  / :   ' |            |   | ;\  \:   ' |    '   ; : \  | 
          ;   :    /    ;   :    /  :   : :            :   ' | \.':   : :    '   | '/  .' 
           \   \ .'      \   \ .'   |   | :            :   : :-'  |   | :    |   :    /   
            `---`         `---`     `---'.|            |   |.'    `---'.|     \   \ .'    
                                      `---`            `---'        `---`      `---`      
                                                                                  
                          --------------------------------------------
                                  PRESS ANY KEY TO START
        ");
        Console.ReadKey();
        Console.Clear();
    }

}
