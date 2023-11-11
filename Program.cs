using System;
using System.Collections.Generic;
public class Game:IComparable<Game> /// \brief Класс ,который в себе хранит Конструктор персонажа,его данные
{
public string Title ; /// \brief Переменная ,которая предназначена для хранения класса
public int ReleaseYear ; /// \brief Переменная ,которая предназначена для хранения уровня
public string Race ; /// \brief Переменная ,которая предназначена для хранения расы
public string Nickname ; /// \brief Переменная ,которая предназначена для хранения никнейма

public Game(string title, int releaseYear, string race, string nickname)
{
Title = title;
ReleaseYear = releaseYear;
Nickname = nickname;
Race = race;
}
/// \brief КМетод который позваляет сравнить персонажей по уровню
public int CompareTo(Game other)
{
return ReleaseYear.CompareTo(other.ReleaseYear);
}
}

public class GameCollectionBase /// \brief Класс ,который в себе хранит лист с персонажами ,а также методы для взаимодействия с этими персонажами
{
protected List<Game> games;

public GameCollectionBase()
{
games = new List<Game>();
}

/// \brief Метод для добавления нового персонажа в коллекцию
public void AddGame(Game game)
{
games.Add(game);
}

/// \brief Метод для удаления Персонажа
public void removeGame(Game game){
games.Remove(game);
}

/// \brief Метод для удаления всех персонажей

public void remoeAll(){
games.Clear();
Console.WriteLine("Вы удалили всех персонажей");
}

/// \brief Метод для получения всех персонажей
public List<Game> GetAllGames()
{
return games;
}

/// \brief Метод для получения персонажа по расе
public void DisplayGamesByRace(string race){
List<Game> gamesByRace = games.FindAll(game => game.Race == race);

Console.WriteLine($"Персонажи с расой {race}:");
foreach (Game game in gamesByRace)
{
Console.WriteLine("Никнейм: " + game.Nickname);
Console.WriteLine("Класс: " + game.Title);
Console.WriteLine("Уровень: " + game.ReleaseYear);
Console.WriteLine();
}
}

/// \brief Метод для получения персонажа по уровню
public void DisplayGamesByLvl(int releaseYear){
List<Game> gamesByLvl = games.FindAll(game => game.ReleaseYear == releaseYear);

Console.WriteLine($"Персонажи с уровнем {releaseYear}:");
foreach (Game game in gamesByLvl)
{
Console.WriteLine("Никнейм: " + game.Nickname);
Console.WriteLine("Класс: " + game.Title);
Console.WriteLine("Уровень: " + game.ReleaseYear);
Console.WriteLine();
}
}

/// \brief Метод для получения персонажа по классу
public void DisplayGamesByClass(string title){
List<Game> gamesByClass = games.FindAll(game => game.Title == title);

Console.WriteLine($"Персонажи с классом {title}:");
foreach (Game game in gamesByClass)
{
Console.WriteLine("Никнейм: " + game.Nickname);
Console.WriteLine("Класс: " + game.Title);
Console.WriteLine("Уровень: " + game.ReleaseYear);
Console.WriteLine();
}
}
}

public class GameCollection : GameCollectionBase /// \brief Вспомогательный класс ,который наследуется от GameCollectionBase
{
public GameCollection() : base()
{
}

/// \brief brief Метод вывода данных
public void DisplayGames()
{
if (games.Count == 0)
{
Console.WriteLine("Коллекция игр пуста.");
}
else
{
Console.WriteLine("Информация об играх:");

foreach (Game game in games)
{
Console.WriteLine("Никнейм: " + game.Nickname);
Console.WriteLine("Класс: " + game.Title);
Console.WriteLine("Уровень: " + game.ReleaseYear);
Console.WriteLine("Раса: " + game.Race);
Console.WriteLine();
}
}
}
}

public class Program /// \brief Класс ,который является основным
{
/// \briefМетод для вызова Данных
public static void Main(string[] args)
{
GameCollection gameCollection = new GameCollection();

Game game1 = new Game("Warlock", 15, "Human", "proKiller");
Game game2 = new Game("Tatakae", 15, "Elf", "Worgen");
Game game3 = new Game("Kiyotaka", 110, "Demon Hunter", "Night Elf");

gameCollection.AddGame(game1);
gameCollection.AddGame(game2);
gameCollection.AddGame(game3);
gameCollection.DisplayGamesByLvl(110);
}
}
