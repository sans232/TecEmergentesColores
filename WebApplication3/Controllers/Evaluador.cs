

using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;


namespace WebApplication3.Controllers
{
    public class Evaluador
    {
        public string Evaluar(int idMensaje, int idColor1,int idColor2, int idColor3, bool respuesta)
        {
            string evaluacion = "Arreglar si aparece este resultado";
            string evaluacion2 = "Neutral";

            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "emprendedor"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "optimista"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "sincero"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "noble"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "eficaz"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "sincero"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "ingenioso"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "responzable"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "optimist"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "emprendedor"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "competentre"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "eficaz"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "noble"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "sincero"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "sincero"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "ingeniosa"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "optimista"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "emprendedor"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "emprendedor"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "optimista"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "eficaz"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "noble"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "sincero"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "ingenioso"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "distinguido"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "emotivo"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "responsable"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "audaz"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "eficaz"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "noble"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "ingenioso"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "confible"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "sensato"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "afectuoso"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "intrepido"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "certero"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "cuidadoso"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "creativo"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "productivo"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "noble"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "lider"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "emprendedor"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "dedicado"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 2 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 3 && respuesta == true) { evaluacion = "positivo"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 4 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 5 && respuesta == true) { evaluacion = "eficaz"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 1 && respuesta == true) { evaluacion = "simpatico"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 2 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 3 && respuesta == true) { evaluacion = "confiable"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 4 && respuesta == true) { evaluacion = "competente"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 5 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 1 && respuesta == true) { evaluacion = "elegante"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 2 && respuesta == true) { evaluacion = "ingenioso"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 3 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 4 && respuesta == true) { evaluacion = "decidido"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 5 && respuesta == true) { evaluacion = "entusiasta"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 1 && respuesta == true) { evaluacion = "prospero"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 2 && respuesta == true) { evaluacion = "ingenioso"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 3 && respuesta == true) { evaluacion = "determinado"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 4 && respuesta == true) { evaluacion = "asertivo"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 5 && respuesta == true) { evaluacion = "organizado"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 1 && respuesta == true) { evaluacion = "eficiente"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 2 && respuesta == true) { evaluacion = "motivado"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 3 && respuesta == true) { evaluacion = "comprometido"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 4 && respuesta == true) { evaluacion = "coherente"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 5 && respuesta == true) { evaluacion = "competente"; }




            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 1 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 1 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 1 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "deshonesto"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 1 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 1 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 2 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 2 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 2 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "deshonesto"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 2 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "frustado"; }
            if (idMensaje == 2 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 3 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 3 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 3 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 3 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 3 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 4 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 4 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 4 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 4 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 4 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 5 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 5 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 5 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 5 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 5 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 6 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 6 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 6 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 6 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 6 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 7 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 7 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 7 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 7 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 7 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 8 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 8 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 8 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 8 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 8 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 9 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 9 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 9 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 9 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 9 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 1 && respuesta == false) { evaluacion = "distanciado"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 2 && respuesta == false) { evaluacion = "depresivo"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 3 && respuesta == false) { evaluacion = "indeciso"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 4 && respuesta == false) { evaluacion = "evasivo"; }
            if (idMensaje == 10 && idColor1 == 1 && idColor2 == 5 && respuesta == false) { evaluacion = "olvidadizo"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 1 && respuesta == false) { evaluacion = "conformista"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 2 && respuesta == false) { evaluacion = "irresponsable"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 3 && respuesta == false) { evaluacion = "mentiroso"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 4 && respuesta == false) { evaluacion = "antisocial"; }
            if (idMensaje == 10 && idColor1 == 2 && idColor2 == 5 && respuesta == false) { evaluacion = "paranoico"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 1 && respuesta == false) { evaluacion = "tramposo"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 2 && respuesta == false) { evaluacion = "cerrado"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 3 && respuesta == false) { evaluacion = "corrupto"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 4 && respuesta == false) { evaluacion = "impaciente"; }
            if (idMensaje == 10 && idColor1 == 3 && idColor2 == 5 && respuesta == false) { evaluacion = "obsesivo"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 1 && respuesta == false) { evaluacion = "desmotivado"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 2 && respuesta == false) { evaluacion = "impulsivo"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 3 && respuesta == false) { evaluacion = "autoritario"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 4 && respuesta == false) { evaluacion = "desconfiado"; }
            if (idMensaje == 10 && idColor1 == 4 && idColor2 == 5 && respuesta == false) { evaluacion = "nervioso"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 1 && respuesta == false) { evaluacion = "distraido"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 2 && respuesta == false) { evaluacion = "frustrado"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 3 && respuesta == false) { evaluacion = "pesimista"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 4 && respuesta == false) { evaluacion = "rencoroso"; }
            if (idMensaje == 10 && idColor1 == 5 && idColor2 == 5 && respuesta == false) { evaluacion = "depresivo"; }




            if (evaluacion == "elegante" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Pulcro"; }
            if (evaluacion == "emotivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Emocional"; }
            if (evaluacion == "lider" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Lider"; }
            if (evaluacion == "determinado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Decidido"; }
            if (evaluacion == "eficiente" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Organizado"; }
            if (evaluacion == "simpatico" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Amistoso"; }
            if (evaluacion == "motivado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Determinado"; }
            if (evaluacion == "asertivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Enfocado"; }
            if (evaluacion == "decidido" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Determinado"; }
            if (evaluacion == "coherente" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Reflexivo"; }
            if (evaluacion == "entusiasta" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Aplicado"; }
            if (evaluacion == "creativo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Intelectual"; }
            if (evaluacion == "competente" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Ingenioso"; }
            if (evaluacion == "prospero" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Emprendedor"; }
            if (evaluacion == "emprendedor" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Negociador"; }
            if (evaluacion == "optimista" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Alegre"; }
            if (evaluacion == "organizado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Responsable"; }
            if (evaluacion == "dedicado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Organizado"; }
            if (evaluacion == "comprometido" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Confiable"; }
            if (evaluacion == "confiable" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Leal"; }
            if (evaluacion == "sensato" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Pensativo"; }
            if (evaluacion == "distinguido" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Carismatico"; }
            if (evaluacion == "afectuoso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Empatico"; }
            if (evaluacion == "responsable" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Aplicado"; }
            if (evaluacion == "intrepido" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Valiente"; }
            if (evaluacion == "competente" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Lider"; }
            if (evaluacion == "audaz" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Atento"; }
            if (evaluacion == "certero" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Preciso"; }
            if (evaluacion == "cuidadoso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Empatico"; }
            if (evaluacion == "productivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Productivo"; }
            if (evaluacion == "ingenioso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Intelectual"; }
            if (evaluacion == "sincero" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Empatico"; }
            if (evaluacion == "noble" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Carismatico"; }
            if (evaluacion == "positivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Optimista"; }
            if (evaluacion == "eficaz" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Organizado"; }


            if (evaluacion == "rencoroso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Resentido"; }
            if (evaluacion == "pesimista" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Desmotivado"; }
            if (evaluacion == "frustrado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Rencoroso"; }
            if (evaluacion == "distraido" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Desenfocado"; }
            if (evaluacion == "nervioso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Cauteloso"; }
            if (evaluacion == "desconfiado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Cuidadoso"; }
            if (evaluacion == "autoritario" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Responsable"; }
            if (evaluacion == "impulsivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Impaciente"; }
            if (evaluacion == "desmotivado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Distraido"; }
            if (evaluacion == "obsesivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Obsesivo"; }
            if (evaluacion == "impaciente" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Impulsivo"; }
            if (evaluacion == "corrupto" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Imparcial"; }
            if (evaluacion == "cerrado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Distanciado"; }
            if (evaluacion == "tramposo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Engañoso"; }
            if (evaluacion == "paranoico" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Nervioso"; }
            if (evaluacion == "antisocial" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Cerrado"; }
            if (evaluacion == "mentiroso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Mentiroso"; }
            if (evaluacion == "irresponsable" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Flojo"; }
            if (evaluacion == "conformista" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Conformista"; }
            if (evaluacion == "olvidadizo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Distraido"; }
            if (evaluacion == "evasivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Distraido"; }
            if (evaluacion == "indeciso" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Indeciso"; }
            if (evaluacion == "depresivo" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Desmotivado"; }
            if (evaluacion == "distanciado" && idColor3 >= 1 && idColor3 <= 3) { evaluacion2 = "Distanciado"; }





            if (evaluacion == "elegante" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Cauteloso"; }
            if (evaluacion == "emotivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Emocional"; }
            if (evaluacion == "lider" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Autoritario"; }
            if (evaluacion == "determinado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Centrado"; }
            if (evaluacion == "eficiente" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Responsable"; }
            if (evaluacion == "simpatico" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Decente"; }
            if (evaluacion == "motivado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Cumplido"; }
            if (evaluacion == "asertivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Dominante"; }
            if (evaluacion == "decidido" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Centrado"; }
            if (evaluacion == "coherente" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Listo"; }
            if (evaluacion == "entusiasta" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Aplicado"; }
            if (evaluacion == "creativo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Ingenioso"; }
            if (evaluacion == "entusiasta" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Preparado"; }
            if (evaluacion == "competente" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Listo"; }
            if (evaluacion == "prospero" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Aplicado"; }
            if (evaluacion == "emprendedor" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Negociador"; }
            if (evaluacion == "optimista" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Realista"; }
            if (evaluacion == "organizado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Cauteloso"; }
            if (evaluacion == "dedicado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Decidido"; }
            if (evaluacion == "comprometido" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Responsable"; }
            if (evaluacion == "confiable" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Comprometido"; }
            if (evaluacion == "sensato" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Precavido"; }
            if (evaluacion == "distinguido" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Decente"; }
            if (evaluacion == "afectuoso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Emotivo"; }
            if (evaluacion == "responsable" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Aplicado"; }
            if (evaluacion == "intrepido" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Precavido"; }
            if (evaluacion == "competente" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Responsable"; }
            if (evaluacion == "audaz" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Planificador"; }
            if (evaluacion == "certero" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Puntual"; }
            if (evaluacion == "cuidadoso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Precavido"; }
            if (evaluacion == "creativo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Ingenioso"; }
            if (evaluacion == "productivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Productivo"; }
            if (evaluacion == "ingenioso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Listo"; }
            if (evaluacion == "sincero" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Directo"; }
            if (evaluacion == "noble" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Educado"; }
            if (evaluacion == "positivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Realista"; }
            if (evaluacion == "eficaz" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Preparado"; }


            if (evaluacion == "rencoroso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Vengativo"; }
            if (evaluacion == "pesimista" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Depresivo"; }
            if (evaluacion == "frustrado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Rencoroso"; }
            if (evaluacion == "distraido" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Despistado"; }
            if (evaluacion == "nervioso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Paranoico"; }
            if (evaluacion == "desconfiado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Antisocial"; }
            if (evaluacion == "autoritario" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Irritable"; }
            if (evaluacion == "impulsivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Impulsivo"; }
            if (evaluacion == "desmotivado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Depresivo"; }
            if (evaluacion == "obsesivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Obsesivo"; }
            if (evaluacion == "impaciente" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Impulsivo"; }
            if (evaluacion == "corrupto" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Corrupto"; }
            if (evaluacion == "cerrado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Desconfiado"; }
            if (evaluacion == "tramposo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Traicionero"; }
            if (evaluacion == "paranoico" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Paranoico"; }
            if (evaluacion == "antisocial" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Distanciado"; }
            if (evaluacion == "mentiroso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Mentiroso"; }
            if (evaluacion == "irresponsable" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Desobligado"; }
            if (evaluacion == "conformista" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Mediocre"; }
            if (evaluacion == "olvidadizo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Depresivo"; }
            if (evaluacion == "evasivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Distanciado"; }
            if (evaluacion == "indeciso" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Indeciso"; }
            if (evaluacion == "depresivo" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Depresivo"; }
            if (evaluacion == "distanciado" && idColor3 >= 4 && idColor3 <= 6) { evaluacion2 = "Alejado"; }




            return evaluacion2;
        }

        
    }

    

}
