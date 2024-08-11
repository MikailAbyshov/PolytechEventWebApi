namespace Data.Configuration;

/// <summary>
/// Настройки подключения к базе данных
/// </summary>
public sealed class DatabaseOptions
{
  /// <summary>
  /// Ключ секции для настроек подключения к базе данных
  /// </summary>
  public static string SectionKey => "DatabaseOptions";

  /// <summary>
  /// Использовать PostgreSQL?
  /// </summary>
  public bool UsePostgreSql { get; init; }

  /// <summary>
  /// Создать новую базу данных?
  /// </summary>
  public bool CreateNewDatabase { get; init; }
}