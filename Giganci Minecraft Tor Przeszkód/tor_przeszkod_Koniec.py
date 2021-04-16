# Miejsce na definicje funckji

def przegrana():
    # Ustawienie dnia
    gameplay.time_set(DayTime.Day)
    # Ustawienie trybu kreatywnego
    gameplay.set_game_mode(CREATIVE, mobs.target(NEAREST_PLAYER))
    # Usunięcie potworków
    gameplay.set_difficulty(PEACEFUL)
    loops.pause(500)
    gameplay.set_difficulty(NORMAL)
    pass  # Koniec funkcji przegrana()

# Ta funkcja przygotowuje pierwszy segment toru
def tor():
    # Uaktualnienie naszej pozycji
    # Czyli odczytujemy ją jeszcze raz
    pozycja=player.position()
    # Specjalna konstrukcja, ktora sprawia, 
    # że uaktualnimy zmienne utworzone poza funkcją 
    global x, y, z 
    # Zapis nowych wartości (aktualnej pozycji gracza) 
    x = pozycja.get_value(Axis.X)
    y = pozycja.get_value(Axis.Y)
    z = pozycja.get_value(Axis.Z)

    # Tworzymy bryłę toru (ściany i podłogę)
    blocks.fill(BEDROCK, world(x-10,y-1,z-2), world(x+10,y+10,z+35))
    blocks.fill(AIR,     world(x-9, y,  z-2), world(x+9, y+10,z+34))
    blocks.fill(GLASS,   world(x-9, y,  z-1), world(x+9, y+10,z-1))

    # Tworzymy pierwszą linię uruchamiającą pierwszy etap
    blocks.fill(SEA_LANTERN, world(x-9,y-1,z+3),world(x+9,y-1,z+5))
    # Ustawiamy czas gry na noc dla lepszego klimatu
    gameplay.time_set(DayTime.NIGHT)
    # Ustawienie trybu przetrwania
    gameplay.set_game_mode(SURVIVAL, mobs.target(NEAREST_PLAYER))
    pass  # Koniec funkcji tor()


# Funkcja odpowiedzialna za tworzenie etapu nr 1 naszego toru przeszkód
def etap1(z):
    # nasz postać napisze na czacie "Etap 1"
    player.say("Etap 1")

    # Dokładamy kolejny segment do naszego toru
    blocks.fill(BEDROCK, world(x-10,y-1,z-2),world(x+10,y+10,z+30))
    blocks.fill(AIR,     world(x-9,y,z-1),   world(x+9,y+10,z+29))

    # Usuwamy pas uruchamiający etap1 
    # (aby nie zresetować sobie właśnie co stworzonego poziomu)
    # Robimy to za pomocą wstawienia tam bloków skały macierzystej
    blocks.fill(BEDROCK, world(x-10,y-1,z-5),world(x+10,y-1,z+5))
    # Dodajemy przegrodę za graczem
    blocks.fill(BEDROCK, world(x-10,y,z-3),  world(x+10,y+10,z-1))

    # Tworzymy pas, który uruchomi KOLEJNY etap - Pas złotych bloków
    blocks.fill(GOLD_BLOCK, world(x-9,y-1,z+25),world(x+9,y-1,z+27))

    # Utworzenie przeszkód w pierwszym etapie
    # Lawa oraz metalowe kraty - do których możemy wpaść
    blocks.fill(IRON_BARS, world(x-9,y-1,z+3), world(x+9,y-1,z+20))
    blocks.fill(LAVA,       world(x-9,y-2,z+3),world(x+9,y-2,z+20))

    # Przekazanie naszemu graczowi siekiery
    mobs.give(mobs.target(NEAREST_PLAYER), DIAMOND_AXE, 1)

    # Dodaj 5 pierwszych Creepereow
    for i in range(5):
        mobs.spawn(CREEPER, randpos(world(x-8,y+1,z+3), world(x+8,y+1,z+20)))
        # CREEPER - potwór, który jest spawnowany
        # randpos(...) - wylosowana pozycja dla potworka
        pass

    # Powtarzaj cały czas kod wewnątrz wcięcia
    while True:
        # Jeżeli pod nami znajduje się blok IRON_BARS
        if blocks.test_for_block(IRON_BARS, pos(0, -1, 0)):
            # Dodaj jednego creepera i poczekaj sekundę
            mobs.spawn(CREEPER, randpos(world(x-8,y+1,z+3), world(x+8,y+1,z+20)))
            loops.pause(1000)
            pass  # Koniec sprawdzania, czy pod nami jest IRON_BARS - metalowa krata

        # Jeżeli pod nami znajduje się blok GOLD_BLOCK
        if blocks.test_for_block(GOLD_BLOCK, pos(0, -1, 0)):
            # Wychodzimy z petli while za pomocą instrukcji "break"
            break
            pass  # Koniec sprawdzania, czy pod nami jest GOLD_BLOCK

        pass  # Koniec while True

    # Napisz na czacie koniec etapu 1
    player.say("Ukonczyles etap 1")

    # Koniec etapu 1
    pass  # Koniec funkcji etap1(z) - Program wraca do miejsca, w ktorym wywołano tę funkcję


def etap2(z):
    # nasz postać napisze na czacie "Etap 1"
    player.say("Etap 2")

    # Dokładamy kolejny segment do naszego toru
    blocks.fill(BEDROCK, world(x-10,y-1,z-2),world(x+10,y+10,z+30))
    blocks.fill(AIR,     world(x-9, y,  z-1),world(x+9, y+10,z+29))

    # Usuwamy pas uruchamiający etap1 
    # (aby nie zresetować sobie właśnie co stworzonego poziomu)
    # Robimy to za pomocą wstawienia tam bloków skały macierzystej
    blocks.fill(BEDROCK, world(x-10,y-1,z-5),world(x+10,y-1,z+5))
    # Dodajemy przegrodę za graczem
    blocks.fill(BEDROCK, world(x-10,y,z-3),  world(x+10,y+10,z-1))

    # Tworzymy pas, który uruchomi KOLEJNY etap - Pas złotych bloków
    blocks.fill(GLASS, world(x-9,y-1,z+25),world(x+9,y-1,z+27))

    # Utworzenie przeszkód w pierwszym etapie
    
    # Wykonaj 10 razy kod zawarty wewnątrz wcięcia
    for i in range(10):
        # Spawnuj zombie w losowym miejscu (ale wewnatrz naszego etapu)
        mobs.spawn(ZOMBIE, randpos(world(x-8,y+3,z+3), world(x+8,y+3,z+20)))
        pass  # Koniec for i in range(...)

    pass # Koniec funkcji etap2(z) - Program wraca do miejsca, w ktorym wywołano tę funkcję

def etap3(z):
    # nasz postać napisze na czacie "Etap 3"
    player.say("Etap 3")
    # Dokładamy kolejny segment do naszego toru
    blocks.fill(BEDROCK, world(x-10,y-1,z-2),world(x+10,y+10,z+30))
    blocks.fill(AIR,     world(x-9, y,  z-1),world(x+9, y+10,z+29))
    # Usuwamy poprzedni pas uruchamiający 
    # (aby nie zresetować sobie właśnie co stworzonego poziomu)
    # Robimy to za pomocą wstawienia tam bloków skały macierzystej
    blocks.fill(BEDROCK, world(x-10,y-1,z-5),world(x+10,y-1,z+5))
    # Dodajemy przegrodę za graczem
    blocks.fill(BEDROCK, world(x-10,y,z-3),  world(x+10,y+10,z-1))
    # Tworzymy pas, który uruchomi KOLEJNY etap - Pas złotych bloków
    blocks.fill(BLOCK_OF_QUARTZ, world(x-9,y-1,z+25),world(x+9,y-1,z+27))
    # Utworzenie przeszkód w pierwszym etapie
    
    # Utworzenie diamentowej podłogi
    blocks.fill(DIAMOND_BLOCK, world(x-9, y-1, z+3), world(x+9, y-1, z+20))

    # Spadające TNT, jezeli stoimy na diamentowym bloku
    while True:
        # Czy stoimy na diamentowym bloku?
        if blocks.test_for_block(DIAMOND_BLOCK, pos(0, -1, 0)):
            # Co powinno się dziać, jeżeli stoimy na diamentowym bloku?
            # Spawnujemy podpalone TNT w losowej pozycji
            mobs.spawn(PRIMED_TNT, randpos(world(x-8,y+3,z+3), world(x+8,y+3,z+20)))
            # Opóźnienie między kolejnymi bombami TNT
            loops.pause(100)
            pass  # Koniec ifa sprawdzającego czy stoimy na diamentowym bloku

        # Czy stoimy na bloku kwarcu? Czyli czy zakonczylismy ten etap?
        if blocks.test_for_block(BLOCK_OF_QUARTZ, pos(0, -1, 0)):
            break  # Instrukcja powodująca wyjście z pętli while
            pass  # Koniec ifa sprawdzającego czy stoimy na bloku kwarcu

        pass  # Koniec pętli while True

    pass # Koniec funkcji etap3(z)


def etap4(z):
    # nasz postać napisze na czacie "Etap 4"
    player.say("Etap 4")
    # Dokładamy kolejny segment do naszego toru
    blocks.fill(BEDROCK, world(x-10,y-1,z-2),world(x+10,y+10,z+30))
    blocks.fill(AIR,     world(x-9, y,  z-1),world(x+9, y+10,z+29))
    # Usuwamy pas uruchamiający etap1 
    # (aby nie zresetować sobie właśnie co stworzonego poziomu)
    # Robimy to za pomocą wstawienia tam bloków skały macierzystej
    blocks.fill(BEDROCK, world(x-10,y-1,z-5),world(x+10,y-1,z+5))
    # Dodajemy przegrodę za graczem
    blocks.fill(BEDROCK, world(x-10,y,z-3),  world(x+10,y+10,z-1))
    # Tworzymy pas, który uruchomi KOLEJNY etap - Pas złotych bloków
    blocks.fill(COBBLESTONE, world(x-9,y-1,z+25),world(x+9,y-1,z+27))
    # Utworzenie przeszkód w pierwszym etapie
    
    # Za pomocą pętli for powtarzamy kod zawarty wewnątrz wcięcia
    for i in range(5):
        # Wylej lawę
        blocks.place(LAVA, randpos(world(x-8,y+3,z+3), world(x+8,y+3,z+20)))
        pass  # Koniec pętli for 
    
    pass # Koniec funkcji etapXXX(z)


# Koniec definicji funkcji
# --- ---  --- ---  --- ---  --- ---  --- ---  --- ---  --- --- 
# Utworzenie "komendy" z czatu dla naszej funkcji
# Po wpisaniu odpowiedniego słowa zostanie wykonana wskazana funkcja
player.on_chat("start", tor)  # Po wpisaniu "start" uruchomi się funkcja "tor"

player.on_died(przegrana)  # Kiedy gracz zginie uruchamiana jest funkcja "przegrana"
# --- ---  --- ---  --- ---  --- ---  --- ---  --- ---  --- --- 
# Kod uruchamiany przy uruchomieniu

# Usuń obecne potworki - Wywołaj funkcję "przegrana"
przegrana()

# Przy uruchomieniu odczytujemy aktualna pozycje gracza
pozycja = player.position()
x = pozycja.get_value(Axis.X)
y = pozycja.get_value(Axis.Y)
z = pozycja.get_value(Axis.Z)

# Kod odpowiedzialny za ładowanie kolejnych etapów
while True:  
    # /\ ta instrukcja pozwala nam ciągle powtarzać wcięty kod
    
    # Sprawdzamy jaki blok jest pod nami, czyli na jakim
    # bloku obecnie stoimy
    if blocks.test_for_block(SEA_LANTERN, pos(0, -1, 0)):
        # SEA_LANTERN - Chcemy, aby ten blok znajdował się we wskazanej pozycji w świecie Minecrafta
        # pos(0, -1, 0) - Wskazana pozycja w zalezności od naszego gracza.
        #     x,  y, z  - y to współrzędna wysokości, czyli sprawdzamy 1 blok POD nami

        # Odczytujemy pozycję naszej postaci
        # i aktualizujemy TYLKO współrzędna Z (x i y nie możemy zmienić)
        pozycja=player.position()
        z = pozycja.get_value(Axis.Z)
        # Uruchamiamy funkcję odpowiedzialną za tworzenie etapu nr 1
        etap1(z)
        # Po wykonaniu funkcji "etap1" zatrzymujemy nasz program na 0,5 sekundy (500 milisekund)
        loops.pause(500)
        pass  # Koniec wcięcia dla if
    elif blocks.test_for_block(GOLD_BLOCK, pos(0, -1, 0)):
        # Odczytaj aktualna pozycje gracza
        pozycja=player.position()
        # Zapisz współrzędną Z do zmiennej (x i y nie możemy zmienić)
        z = pozycja.get_value(Axis.Z)
        # Uruchom funkcje odpowiedzialna za etap 2
        etap2(z)
        pass  # Koniec wcięcia dla elif
    elif blocks.test_for_block(GLASS, pos(0, -1, 0)):
        # Odczytaj aktualna pozycje gracza
        pozycja=player.position()
        # Zapisz współrzędną Z do zmiennej (x i y nie możemy zmienić)
        z = pozycja.get_value(Axis.Z)
        # Uruchom funkcje odpowiedzialna za etap 3
        etap3(z)
        pass  # 
    elif blocks.test_for_block(BLOCK_OF_QUARTZ, pos(0, -1, 0)):
        # Odczytaj aktualna pozycje gracza
        pozycja=player.position()
        # Zapisz współrzędną Z do zmiennej (x i y nie możemy zmienić)
        z = pozycja.get_value(Axis.Z)
        # Uruchom funkcje odpowiedzialna za etap 4
        etap4(z)
        pass  # Koniec wcięcia dla elif

    pass  # Koniec pętli while True


# --- ---  --- ---  --- ---  --- ---  --- ---  --- ---  --- --- 
# PODSUMOWANIE

# Etap 1
#   Uruchamiany za pomocą bloku SEA_LANTERN
#   Lawa, metalowe kraty oraz creepery
# Etap 2
#   Uruchamiany za pomocą bloku GOLD_BLOCK
#   DUŻO Zombie
# Etap 3
#   Uruchamiany za pomocą bloku GLASS
#   Podłoga z diamentowych bloków oraz spadające TNT
# Etap 4
#   Uruchamiany za pomocą BLOCK_OF_QUARTZ
#   
# Etap 5 COBBLESTONE



# --- ---  --- ---  --- ---  --- ---  --- ---  --- ---  --- --- 
# Jak samemu stworzyć nowy etap?
"""
1) Dodaj kolejny elif. Pamiętaj o zamianie:
    BLOK_KOLEJNEGO_ETAPU - Odpowiedni blok, który nie był jeszcze wykorzystany
    etapXXX(z) - odpowiednia nazwa funkcji, XXX to numer etapu

elif blocks.test_for_block(BLOK_KOLEJNEGO_ETAPU, pos(0, -1, 0)):
    # Odczytaj aktualna pozycje gracza
    pozycja=player.position()
    # Zapisz współrzędną Z do zmiennej (x i y nie możemy zmienić)
    z = pozycja.get_value(Axis.Z)
    # Uruchom funkcje odpowiedzialna za etap XXX
    etapXXX(z)
    pass  # Koniec wcięcia dla elif

2) Stwórz NOWĄ funkcję etapXXX(z), gdzie XXX to numer etapu:
    Pamiętaj o zamianie:
        XXX - Na numer odpowiedniego etapu
        BLOK_KOLEJNEGO ETAPU - blok aktywujący kolejny etap
        (w kolejnym elifie musisz użyć tego samego bloku)
     Dodaj kod odpowiedzialny za wykonanie TWOJEGO pomysłu na ten etap :)  
Przekopiuj sobie wzór funkcji:

def etapXXX(z):
    # nasz postać napisze na czacie "Etap 1"
    player.say("Etap XXX")
    # Dokładamy kolejny segment do naszego toru
    blocks.fill(BEDROCK, world(x-10,y-1,z-2),world(x+10,y+10,z+30))
    blocks.fill(AIR,     world(x-9, y,  z-1),world(x+9, y+10,z+29))
    # Usuwamy pas uruchamiający etap1 
    # (aby nie zresetować sobie właśnie co stworzonego poziomu)
    # Robimy to za pomocą wstawienia tam bloków skały macierzystej
    blocks.fill(BEDROCK, world(x-10,y-1,z-5),world(x+10,y-1,z+5))
    # Dodajemy przegrodę za graczem
    blocks.fill(BEDROCK, world(x-10,y,z-3),  world(x+10,y+10,z-1))
    # Tworzymy pas, który uruchomi KOLEJNY etap - Pas złotych bloków
    blocks.fill(BLOK_KOLEJNEGO, world(x-9,y-1,z+25),world(x+9,y-1,z+27))
    # Utworzenie przeszkód w pierwszym etapie
    
    # # # # # # # # #
    # Tutaj dodaj kod odpowiedzialny za tworzenie nowego etapu
    # # # # # # # # #
    pass # Koniec funkcji etapXXX(z)
# Koniec kopiowania szablonu funkcji
"""

# Pamiętajcie, aby zadawać pytania do niezrozumiałej części kodu!
# Uczmy się razem i bawmy się dobrze z Pythonem oraz Minecraftem
# Autor:
    # Tomek, nauczyciel Giganci :)