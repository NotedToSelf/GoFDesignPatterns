using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class Element
    {


    }

    class Paragraph : Element
    {
        string content;
    }

    class Picture : Element
    {
        private ConsoleColor borderColor;
        private ConsoleColor imageColor;
        private size imageSize;
        private enum size
        {
            small,
            medium,
            large
        }
    }

    class Title : Element
    {
        ConsoleColor textColor;
        string content;
    }

    class LineBreak : Element
    {

    }
}



//Scratchnotes:

/*     Small
 *   ___________
 *  |           |         
 *  |           |
 *  |           |
 *  |           |
 *  |___________|
 */

/*           Medium
 *   ______________________
 *  |                      |         
 *  |                      |
 *  |                      |
 *  |                      |    
 *  |                      |
 *  |                      |
 *  |                      |
 *  |                      |
 *  |______________________|
 */

/*                Large
*   __________________________________
*  |                                  |         
*  |                                  |
*  |                                  |    
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |                                  |
*  |__________________________________|
*/

/*              Medium
*   ______________________
*  |            *         |         
*  | *    *   /\       *  |
*  |         /__\   *     |
*  |   *    /____\        |    
*  |       /______\   *   |
*  |          ||          |
*  |          ||          |
*  |__________||__________|
*/
