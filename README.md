# Ex6_A

בחלק זה עשינו בכל פעם שהשחקן יגיע לטווח ראייה של הסייר, הסייר יתחיל לרדוף אחרי השחקן וכל צעד שיעשה יקבל עיכוב של 3 שניות וכשהוא תופס את השחקן שניהם יעלמו.

ע"מ לשחק במשחק [לחץ כאן](https://m-h-a.itch.io/ex6-a)

נשים לב שהשינויים שעשינו זה על הסצנה בתקייה בשם 3-enemies ושם הסטצנה הוא c-patrol.

נראה בהתחלה את החלק שהסייר ממתין 3 שניות בכל צעד שעושה:

כאשר השחקן נכנס לתחום של הסייר אז הסייר ימתין בפונקציה הזאת:

![image](https://github.com/MHA-FinalProject/Ex6_A_Weekly/assets/118104946/6acbc004-f2d4-4910-9728-68252e4dcc95)

לפי הפונקציית wait הזאת:

![image](https://github.com/MHA-FinalProject/Ex6_A_Weekly/assets/118104946/1a049488-3bee-4c1f-909c-e549cafa143a)

ואפשר לשנות את הזמן של ההמתנה:

![image](https://github.com/MHA-FinalProject/Ex6_A_Weekly/assets/118104946/f2e4a159-9aad-423f-b875-bf5a25d34208)


נראה עכשיו את הקוד שבו השחקן והסייר נעלמים כאשר הסייר תופס אותם:

עשינו סקריפט חדש לשחקן בשם PlayerDisapper שבו עשינו שכאשר הטאג של הסייר הוא הטאג שבו מתנגשים אז שניהם נעלמים:

![image](https://github.com/MHA-FinalProject/Ex6_A_Weekly/assets/118104946/4e00a0b0-b32f-438c-a69a-1401faaabfa0)


שהגדרנו פה איזה טאג:

![image](https://github.com/MHA-FinalProject/Ex6_A_Weekly/assets/118104946/4b0cd873-7f2d-409b-87e6-262908876832)


