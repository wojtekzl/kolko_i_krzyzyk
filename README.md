# Kółko i Krzyżyk (C# WPF)

Prosta gra w kółko i krzyżyk dla dwóch graczy, stworzona w technologii WPF (Windows Presentation Foundation) w C#.  

Gra oferuje interaktywny interfejs graficzny, liczniki wygranych oraz dynamiczne obrazki informujące o wyniku.

<img width="1173" height="652" alt="image" src="https://github.com/user-attachments/assets/bfb65dd2-dcb6-4804-bd93-3fdbde01c7de" />


---

## 🎮 Funkcjonalności

- **Interfejs graficzny WPF**  
  - Plansza 3x3 wykonana z przycisków, które reagują na kliknięcia graczy.  

- **Tryb dla dwóch graczy**  
  - Gracze X i O na przemian wykonują swoje ruchy.  

- **Walidacja ruchów**  
  - Pola, które zostały już zajęte, są zablokowane, aby uniemożliwić nadpisanie ruchu.  

- **Automatyczne wykrywanie zwycięzcy**  
  - Program sprawdza wygraną po każdym ruchu, zarówno w poziomie, pionie, jak i na ukos.  

- **Liczniki wygranych**  
  - Po lewej stronie wyświetlane są liczniki wygranych dla X i O, automatycznie aktualizowane po każdej wygranej.  

- **Dynamiczny obrazek ptaka**  
  - Powyżej wygranych wyświetlany jest obrazek ptaka, który zmienia się po wygranej lub remisie, informując wizualnie o wyniku.  

<img width="80" height="160" alt="wiktoriusz_maly" src="https://github.com/user-attachments/assets/09c37264-8f11-45fe-8ac8-872ca6cf7831" />
<img width="90" height="110" alt="buuu_maly" src="https://github.com/user-attachments/assets/beece702-8f9d-4670-8b04-17dd0b780fd4" />


- **Przyciski sterujące**  
  - **Nowa gra** – resetuje planszę i rozpoczyna nową rozgrywkę.  
  - **Zasady gry** – wyświetla zasady gry w oknie informacyjnym.

- **Informowanie o wyniku**  
  - Po zakończeniu gry wyświetlany jest komunikat w oknie MessageBox: wygrana X, O lub remis.  

- **Losowy start gracza**  
  - Przy rozpoczęciu nowej gry losowany jest gracz rozpoczynający rozgrywkę.

---

## 🛠 Instalacja i uruchomienie

1. **Sklonuj repozytorium:**
   ```bash
  git clone https://github.com/wojtekzl/kolko_i_krzyzyk.git

---

## 📜 Licencja i autor
Projekt udostępniony na licencji MIT License – możesz go dowolnie modyfikować i używać w projektach prywatnych lub komercyjnych.

Autorem projektu jest Wojciech Złonkiewicz.

Projekt wykonano w maju 2025 roku

---
