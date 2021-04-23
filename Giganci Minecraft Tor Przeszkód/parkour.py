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

    pass  # Koniec funkcji nowyParkour



# Kod wykonywany przy starcie programu

# Aktualne miejsce odrodzenia gracza - zmienia się po osiągnięciu checkpointa
aktualnaPozycjaOdrodzenia = player.position()

# Zmienne pomocnicze. Dzięki nim dany etap będzie tworzony tylko raz
czyEtap1Utworzono = False



