using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    MyDictionary<string, string> sinifSube = new MyDictionary<string, string>();
    sinifSube.Ekle("7","B");
    sinifSube.Ekle("4","A");

    sinifSube.HepsiniOkut();
    Console.WriteLine("\n");

    sinifSube.Ekle("12","H");

    sinifSube.HepsiniOkut();
  }
}

class MyDictionary<TKey,TValue>
{
  TKey[] ilkElemanlar;
  TValue[] ikinciElemanlar;
  
  public MyDictionary()
  {
    ilkElemanlar = new TKey[0];
    ikinciElemanlar = new TValue[0];
  }

  public void Ekle(TKey ilkEleman, TValue ikinciEleman)
  {
    TKey[] geciciIlkElemanlar = ilkElemanlar;
    TValue[] geciciIkinciElemanlar = ikinciElemanlar;

    ilkElemanlar = new TKey[ilkElemanlar.Length + 1];
    ikinciElemanlar = new TValue[ikinciElemanlar.Length + 1]; 

    for (int i = 0; i < geciciIlkElemanlar.Length; i++)
    {
      ilkElemanlar[i] = geciciIlkElemanlar[i];
      ikinciElemanlar[i] = geciciIkinciElemanlar[i];
    }

    ilkElemanlar[ilkElemanlar.Length - 1] = ilkEleman;
    ikinciElemanlar[ikinciElemanlar.Length - 1] = ikinciEleman;
  }

  public void HepsiniOkut()
  {
    for (int i = 0; i < ilkElemanlar.Length; i++)
      {
        Console.WriteLine(ilkElemanlar[i] + "/" + ikinciElemanlar[i]);
      }
  }
}