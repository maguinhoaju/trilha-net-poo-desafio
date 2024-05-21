using DesafioPOO.Models;

Nokia nokia1 = new Nokia("79988525233", "C20", "ABCD1234", 6);
Nokia nokia2 = new Nokia("79999999999", "C30", "ABCD1111", 4);
Iphone iPhone1 = new Iphone("79111111111", "15 Pro Max", "XPTO1111", 4);
Iphone iPhone2 = new Iphone("79222222222", "13 Pro", "QWERTY1111", 3);

nokia1.InstalarAplicativo("WhatsApp");
nokia2.InstalarAplicativo("Instagram");
iPhone1.InstalarAplicativo("WhatsApp");
iPhone2.InstalarAplicativo("Facebook");
nokia1.Ligar();
iPhone1.Ligar();
nokia2.ReceberLigacao();
iPhone2.ReceberLigacao();