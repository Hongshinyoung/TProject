//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Networking;
//using UnityEngine.UI;

//public class Weather : MonoBehaviour
//{
//    public string APP_ID;
//    public Text weatherText;
//    public WeatherData weatherInfo;

//    // Start is called before the first frame update
//    void Start()
//    {
//        CheckCityWeather("Seoul");
//    }

//    public void CheckCityWeather(string city)
//    {
//        StartCoroutine(GetWeather(city));
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    IEnumerator GetWeather(string city)
//    {
//        city = UnityWebRequest.EscapeURL(city);
//        string url = "http://api.openweathermap.org/data/2.5/weather?q=Seoul&units=metric&appid=3a62475d216b4407b23ce2573287ab85";

//        UnityWebRequest www = UnityWebRequest.Get(url);
//        yield return www.SendWebRequest();

//        string json = www.downloadHandler.text;
//        json = json.Replace("\"base\":", "\"basem\":");
//        weatherInfo = JsonUtility.FromJson<WeatherData>(json);

//        if (weatherInfo.weather.Length > 0)
//        {
//            weatherText.text = weatherInfo.weather[0].main;
//        }

//    }
//}