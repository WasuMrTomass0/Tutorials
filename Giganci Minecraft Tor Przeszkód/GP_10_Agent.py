# Miejsce na definicje funkcji
"""
Założenia projektowe:
slot 1 - Tory
slot 2 - Zasilane tory
slot 3 - Stone (blok kamienia)
slot 4 - Redstone

kierunek:
numer 1 - kierunek północ     (North)
numer 2 - kierunek południe   (South)
numer 3 - kierunek wschód     (East)
numer 4 - kierunek zachód     (West)

rodzaj torów:
numer 1 - zwykłe tory
numer 2 - zasilane tory
"""
# Funkcja odpowiedzialna za przekazanie wyposażenia
# naszemu agentowi
def uzupelnijBloki():
    # Przekazanie agentowi elementów:
    # pierwszy argument - TYP bloku/przedmiotu, 
    #       który przekazujemy agentowi
    # drugi argument - liczba przekazanych elementów
    # trzeci argument - numer slotu w ekwipunku agenta
    agent.set_item(RAIL, 64, 1)
    agent.set_item(POWERED_RAIL, 64, 2)
    agent.set_item(STONE, 64, 3)
    agent.set_item(REDSTONE_BLOCK, 64, 4)
    pass  # Koniec funkcji uzupelnijBloki


# Funkcja odpowiedzialna za budowanie kolejki (za pomoca agenta)
def budowanieKolejki(iloscTorow, kierunek, rodzaj_torow):
    # # # # Odczytanie argumentow funkcji # # # # 
    
    # Odczytanie kierunku i utworzenie nowej zmiennej pomocniczej
    if kierunek == 1:
        kierunekAgenta = CompassDirection.NORTH
        pass
    elif kierunek == 2:
        kierunekAgenta = CompassDirection.SOUTH
        pass
    elif kierunek == 3:
        kierunekAgenta = CompassDirection.EAST
        pass
    elif kierunek == 4:
        kierunekAgenta = CompassDirection.WEST
        pass
    else:
        # Wprowadzono niepoprawny kierunek. Wyświetl komunikat o błędzie i NIE TWÓRZ TORÓW
        player.say("Podany niepoprawny kierunek! Spróbuj jeszcze raz.")
        return
        pass  # Koniec else

    # Odczytanie rodzaju torow
    if rodzaj_torow == 1:
        slotTorow = 1
        slotBlokuPodTorami = 3
        pass
    elif rodzaj_torow == 2:
        slotTorow = 2
        slotBlokuPodTorami = 4
        pass
    else:
        # Wprowadzono niepoprawny rodzaj torów. Wyświetl komunikat o błędzie i NIE TWÓRZ TORÓW
        player.say("Podano niepoprawny rodzaj torów! Spróbuj jeszcze raz.")
        return
        pass  # Koniec else

    # Utworzenie zmiennej
    # Liczba torów, które zostały już zbudowane
    aktualnaLiczbaTorow = 0

    # Wywołanie funkcji, która przekaże agentowi wszystkie
    # wszystkie potrzebne materiały
    uzupelnijBloki()

    # "Teleportacja" agenta
    # Pozycja agenta nie zmienia się. 
    # Zmieniamy jedynie jego kierunek - na południe ("patrzy")
    agent.teleport(agent.get_position(), kierunekAgenta)

    # # Ustawienia pracy agenta # #
    # Stawianie bloków przy każdym ruchu
    agent.set_assist(PLACE_ON_MOVE, True)
    # Niszczenie przeszkód (bloków, które stoją na jego drodze)
    agent.set_assist(DESTROY_OBSTACLES, True)

    # # Pętla, która działa aż do momentu wybudowania wskazanej
    #   liczby torów (wskazanej przez argument "iloscTorow") # #
    while aktualnaLiczbaTorow < iloscTorow:
        # Sprawdzenie, czy przed agentem lub nad nim znajduje sie jakis blok
        if agent.detect(AgentDetection.BLOCK, FORWARD) or agent.detect(AgentDetection.BLOCK, UP):
            # Usuwamy bloki przed agentem i nad nim
            agent.destroy(FORWARD)
            agent.destroy(UP)
            pass  # Koniec instrukcji warunkowej if
        # Sprawdzamy, czy pod agentem NIE MA bloku
        elif agent.inspect(AgentInspection.BLOCK, DOWN) == 0:
            # Ustawienie slotu agenta na trójkę (slot kamienia)
            # Z tego slotu będą "zabierane" bloczki, które będziemy stawiać
            agent.set_slot(slotBlokuPodTorami)
            # Postawienie bloku pod agentem
            agent.place(DOWN)
            pass  # Koniec elif
        # Jeżeli nie ma potrzeby usuwania bloków przed i nad agentem,
        # ani dodawania bloku pod agentem
        # to oznacza, że miejsce jest gotowe, aby dodać tory
        else:
            # Ustawienie slotu zawierającego tory
            agent.set_slot(slotTorow)
            # Przesunięcie agenta (równoważne z postawieniem bloku 
            #   - patrz instrukcja "agent.set_assist(PLACE_ON_MOVE, True)")
            agent.move(FORWARD, 1)
            # # # 
            # Zanotowanie, że kolejne tory zostały postawione
            # Uaktualnienie liczby w zmiennej "aktualnaLiczbaTorow"
            aktualnaLiczbaTorow += 1
            pass  # Koniec else

        pass  # Koniec pętli while

    # Komunikat na czacie
    player.say("Budowa torów zakończona")

    pass  # Koniec funkcji budowanieKolejki


# # # # # # # # # # # # # # # # # # # # # # # # # # # 
# Miejsce na powiązanie funkcji z komendami, śmierciami gracza, itp

# Utworzenie komendy "b" aktywującej funkcję "budowanieKolejki"
player.on_chat("b", budowanieKolejki)


# # # # # # # # # # # # # # # # # # # # # # # # # # # 
# Kod wykonywany przy starcie skryptu

# Teleportacja agenta do naszego gracza (aktualnej pozycji gracza)
agent.teleport_to_player()
