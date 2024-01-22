from tkinter import *
from tkinter import filedialog
import pandas as pd


class GrafLik:
    """Klasa GrafLik"""

    def __init__(self, boja, tocka):
        self.boja = boja
        self.tocka = tocka

    def SetColor(self, boja):
        """Metoda postavi boju"""
        self.boja = boja

    def GetColor(self):
        """Metoda dohvati boju"""
        return self.boja

    def Draw(self):
        """Nacrtaj oblik - osnovna metoda"""
        return


class Linija(GrafLik):
    """Klasa Linija"""

    def __init__(self, boja, tocka, tocka2):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_line(self.tocka + self.tocka2, fill=self.GetColor())


class Pravokutnik(GrafLik):
    """Klasa Pravokutnik"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_rectangle(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka3),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Poligon(GrafLik):
    """Klasa Poligon"""

    def __init__(self, boja, tocka, tocke):
        GrafLik.__init__(self, boja, tocka)
        self.tocke = tocke

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_polygon(self.tocka + self.tocke, outline=self.GetColor(), fill="")


class Kruznica(GrafLik):
    """Klasa Kruznica"""

    def __init__(self, boja, tocka, tocka2):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_oval(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka2),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Trokut(Linija):
    """Klasa Trokut"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        Linija.__init__(self, boja, tocka, tocka2)
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_polygon(
            self.tocka + self.tocka2 + self.tocka3, outline=self.GetColor(), fill=""
        )


class Elipsa(Kruznica):
    """Klasa Elipsa"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        Kruznica.__init__(self, boja, tocka, tocka2)
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_oval(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka3),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Application(Frame):
    def initializeCanvas(self):
        self.canvas = Canvas(self, bg="#999999", width=800, height=600)
        self.canvas.pack()

    def __init__(self, master=None):
        Frame.__init__(self, master)
        self.master = master
        menu = Menu(self.master)
        self.master.config(menu=menu)
        file_menu = Menu(menu)
        file_menu.add_command(label="Open", command=self.readFile)
        file_menu.add_command(label="Exit", command=self.quit)
        menu.add_cascade(label="File", menu=file_menu)
        self.pack()
        self.initializeCanvas()

    def readFile(self):
        path = filedialog.askopenfilename()
        text = pd.read_csv(path, header=None)
        self.path = path
        self.canvas.delete("all")

        retci = []
        for redak in text[0]:
            retci.append(redak)

        oblici = []
        for oblik in retci:
            oblici.append(oblik.split())

        for oblik in oblici:
            if oblik[0] == "Line":
                linija = Linija(oblik[1], oblik[2:4], oblik[4:6])
                linija.Draw(self.canvas)

            elif oblik[0] == "Rectangle":
                pravokutnik = Pravokutnik(oblik[1], oblik[2:4], oblik[4], oblik[5])
                pravokutnik.Draw(self.canvas)

            elif oblik[0] == "Polygon":
                poligon = Poligon(oblik[1], oblik[2:4], oblik[4:])
                poligon.Draw(self.canvas)

            elif oblik[0] == "Circle":
                kruznica = Kruznica(oblik[1], oblik[2:4], oblik[4])
                kruznica.Draw(self.canvas)

            elif oblik[0] == "Triangle":
                trokut = Trokut(oblik[1], oblik[2:4], oblik[4:6], oblik[6:8])
                trokut.Draw(self.canvas)

            elif oblik[0] == "Ellipse":
                elipsa = Elipsa(oblik[1], oblik[2:4], oblik[4], oblik[5])
                elipsa.Draw(self.canvas)


def main():
    root = Tk()
    app = Application(root)
    root.wm_title("Objektno programiranje - LV4")
    app.mainloop()


if __name__ == "__main__":
    main()
