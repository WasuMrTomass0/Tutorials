# Miejsce na definicje funkcji

# Budowa schodów, które prowadzą do pierwszego etapu toru przeszkód
def nowyParkour():
    # Teleportujemy konstruktor do pozycji (5, 0, 0) obok gracza (względem gracza)    
    builder.teleport_to(pos(5, 0, 0))
    # Obracamy nasz konstruktor
    builder.face(EAST)

    for i in range(70):
        # Stawiamy jeden blok schodów
        builder.place(PURPUR_STAIRS)
        # Przenosimy konstruktor o (1, 1, 0), czyli (x, y, z)
        builder.shift(1, 1, 0)
        pass  # Koniec pętfli for i in range(70)

    # Oznaczamy obecną pozycję konstruktora (zostanie ona zapamiętana)
    builder.mark()
    # Przesuwamy konstruktor w taki sposób, aby przejść do drugiego rogu prostokąta
    builder.shift(2, 0, -4)
    # Wypełnij powstały prostokąt wskazanym blokiem
    builder.fill(DIAMOND_BLOCK)
    pass  # Koniec funkcji nowyParkour

# Funkcja uruchamiana przy kazdej śmierci naszego gracza
def smierc():
    # teleportuj gracza do ostatniego checkpointu
    player.teleport(aktualnaPozycjaOdrodzenia)
    pass  # Koniec funkcji smierc()

# Funkcja tworząca etap 1 oraz etap 2
def etap1i2(kierunekKonstruktora, rodzajToru, rodzajCheckpoint):
    # Argumenty funkcji to:
    # kierunekKonstruktora - kierunek, w którym będzie się przemieszczać nasz konstruktor
    # rodzajToru - blok użyty jako przeszkoda
    # rodzajCheckpoint - blok użyty do stworzenia platformy checkpoint

    # Teleport konstruktora pod plaftormę (1 krok w x, 4 w y w dół, 0 w z)
    builder.teleport_to(pos(1, -4, 0))
    # Zaznaczenie pozycji - zapamiętanie jej
    builder.mark()
    # Upewnienie się, że konstruktor zwrócony jest w odpowiednią stronę
    builder.face(EAST)

    for i in range(2):
        for j in range(5):
            # Przejdź do przodu o X kroków - X to wylosowana liczba od 3 do 8
            builder.move(FORWARD, randint(3, 8))
            # Tworzymy linię od zapamiętanej pozycji do obecnej pozycji
            # za pomocą bloku rodzajToru
            builder.line(rodzajToru)

            # Tworzenie przerwy w torze przeszkód
            # Przejdź do przodu o X kroków - X to wylosowana liczba od 2 do 3
            builder.move(FORWARD, randint(2, 3))
            # Oznaczenie nowej pozycji - zostanie użyta do tworzenia lini
            builder.mark()
            pass  # Koniec pętli for j
        # Ustaw konstruktor w wskazanym kierunku (przez argument funkcji "kierunekKonstruktora")
        builder.turn(kierunekKonstruktora)
        pass  # Koniec pętli for i

    # Utworzenie platformy za tym etapem
    builder.mark()
    builder.shift(2, 0, -4)
    builder.fill(rodzajCheckpoint)
    pass  # Koniec funkcji etap1i2

# Kod wykonywany przy starcie programu

# Przypisanie komendy "start" do wywołania funkcji "nowyParkour"
player.on_chat("start", nowyParkour)
# Wywloanie funkcji "smierc" przy kazdej smierci gracza
player.on_died(smierc)

# Aktualne miejsce odrodzenia gracza - zmienia się po osiągnięciu checkpointa
aktualnaPozycjaOdrodzenia = player.position()

# Zmienne pomocnicze. Dzięki nim dany etap będzie tworzony tylko raz
czyEtap1Utworzono = False

"""
Podsumowanie użytych bloków:
 - Etap 1: DIAMOND_BLOCK
 - Etap 2: GOLD_BLOCK
"""
# Pętla sterująca ładowaniem kolejnych etapów oraz systemem checkpointów
while True:
    # Sprawdzenie czy blok pod graczem to DIAMOND_BLOCK oraz czy jeszcze nie utworzono etapu 1
    if blocks.test_for_block(DIAMOND_BLOCK, pos(0, -1, 0)) and not czyEtap1Utworzono:
        # Odczytujemy aktualną pozycję gracza i zapisujemy ją jako pozycję odrodzenia
        aktualnaPozycjaOdrodzenia = player.position()
        # Zapisanie, ze etap 1 został utworzony
        czyEtap1Utworzono = True
        # Wywołanie funkcji tworzącej etap 1
        etap1i2(RIGHT_TURN, SLIME_BLOCK, GOLD_BLOCK)
        pass  # Koniec if blocks.test_for_block(DIAMOND_BLOCK, pos(0, -1, 0))

    pass  # Koniec pętli while True
