# Miejsce na definicje funkcji
"""
Założenia projektowe:
slot 1 - Tory
slot 2 - Zasilane tory
slot 3 - Stone (blok kamienia)
slot 4 - Redstone
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
def budowanieKolejki(iloscTorow):

    # Utworzenie zmiennej
    # Liczba torów, które zostały już zbudowane
    aktualnaLiczbaTorow = 0

    # Wywołanie funkcji, która przekaże agentowi wszystkie
    # wszystkie potrzebne materiały
    uzupelnijBloki()

    # "Teleportacja" agenta
    # Pozycja agenta nie zmienia się. 
    # Zmieniamy jedynie jego kierunek - na południe ("patrzy")
    agent.teleport(agent.get_position(), SOUTH)

    pass  # Koniec funkcji budowanieKolejki


# # # # # # # # # # # # # # # # # # # # # # # # # # # 
# Miejsce na powiązanie funkcji z komendami, śmierciami gracza, itp




# # # # # # # # # # # # # # # # # # # # # # # # # # # 
# Kod wykonywany przy starcie skryptu

# Teleportacja agenta do naszego gracza (aktualnej pozycji gracza)
agent.teleport_to_player()
