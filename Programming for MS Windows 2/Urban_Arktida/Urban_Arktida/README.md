# Urban Arktida

## Prodělané akce

Pro napojení SQL EXPRESS dabáze jsem musel použít následující příkaz:

```
Scaffold-DbContext "Server=.\SQLExpress;Database=Arktida;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

## Provedené změny

- Aktualizace navigačního menu
- Manuálně aktualizovaný `Startup.cs` soubor o databázový kontext
- Přidána informační stránka
- Přidán dropdown populovaný databází
- Generování tabulky databázovými daty + obrázky 