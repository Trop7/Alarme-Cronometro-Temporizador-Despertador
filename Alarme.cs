using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarme
{
   
    internal class Alarme
    {
       public DateTime Tempo { get; }
       public bool Disparado { get; set; }

        public Alarme()
        {
        
        }
        public Alarme(DateTime tempo)
        {
            Tempo = tempo;
            Disparado = false;
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public string Datalbl()
        {
            string hora = DateTime.Now.ToString("dddd, MMMM yyyy");
            return hora;
        }
        public static void PreencherComboBoxHora(ComboBox comboBox)
        {
            List<string> horas = new List<string>();
            DateTime currentTime = DateTime.Now;

            // Adiciona os horas de 00 a 23 à lista
            for (int i = 0; i <= 23; i++)
            {
                horas.Add(i.ToString("00")); // Formata o número para ter dois dígitos (ex: 01, 02, ..., 23)
            }

            // Limpa os itens existentes no ComboBox e adiciona os minutos
            comboBox.Items.Clear();
            comboBox.Items.AddRange(horas.ToArray());
            comboBox.SelectedIndex = currentTime.Hour;
        }
        public static void PreencherComboBoxMinutos(ComboBox comboBox)
        {
            List<string> minutos = new List<string>();
            DateTime currentTime = DateTime.Now;

            // Adiciona os minutos de 00 a 59 à lista
            for (int i = 0; i < 60; i++)
            {
                minutos.Add(i.ToString("00")); // Formata o número para ter dois dígitos (ex: 01, 02, ..., 59)
            }

            // Limpa os itens existentes no ComboBox e adiciona os minutos
            comboBox.Items.Clear();
            comboBox.Items.AddRange(minutos.ToArray());
            comboBox.SelectedIndex = currentTime.Minute;
        }
        public static void PreencherComboBoxSegundos(ComboBox comboBox)
        {

            List<string> segundos = new List<string>();
            DateTime currentTime = DateTime.Now;

            // Adiciona os segundos de 00 a 59 à lista
            for (int i = 0; i < 60; i++)
            {
                segundos.Add(i.ToString("00")); // Formata o número para ter dois dígitos (ex: 01, 02, ..., 59)
            }

            // Limpa os itens existentes no ComboBox e adiciona os minutos
            comboBox.Items.Clear();
            comboBox.Items.AddRange(segundos.ToArray());
            comboBox.SelectedIndex = currentTime.Second;
        }
    }

 }
/*
 * A tabela a seguir descreve vários formatos C- DateTime e seus resultados. Aqui vemos todos os padrões do C- DateTime, formato e resultados.
Formato de forma 	Resultado
DateTime.Now.ToString("MM/dd/aaaa) 	29/05/2015
DateTime.Now.ToString("dddd, MMMM yyyyy") 	Sexta-feira, 29 de Maio de 2015
DateTime.Now.ToString("dddd, MMMM yyyyy") 	Sexta, 29 Maio 2015 05:50
DateTime.Now.ToString("dddd, MMMM yyyyy") 	Sexta-feira, 29 Maio 2015 05:50
DateTime.Now.ToString("dddd, MMMM yyyyy") 	Sexta-feira, 29 Maio 2015 5:50
DateTime.Now.ToString("dddd, MMMM yyyyy") 	Sexta, 29 Maio 2015 05:50
DateTime.Now.ToString("dd, MMMMMM yyyyy HH:mm:ss") 	Sexta-feira, 29 Maio 2015 05:50:06
DateTime.Now.ToString("MM/dd/aaaa HH:mm) 	29/05/2015 05:50
DateTime.Now.ToString("MM/dd/aaaahh: mm tt) 	29/05/2015 05:50
DateTime.Now.ToString("MM/dd/aaaa H:mm) 	29/05/2015 5:50
DateTime.Now.ToString("MM/dd/aaaahm h: mm tt) 	29/05/2015 05:50
DateTime.Now.ToString("MM/dd/aaaa HH:mm:ss") 	29/05/2015 05:50:06
DateTime.Now.ToString("MMMM dd") 	29 de Maio
DateTime.Now.ToString("yyy'-'MM'-'dd'T'HH':'mm':'s.fffffffK") 	2015-05-16T05:50:06.7199222-04:00
DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'s 'GMT') 	Sex, 16 Maio 2015 05:50:06 GMT
DateTime.Now.ToString("yyy'-'MM'-'dd'T'HH':'mm':'ss") 	2015-05-16T05:50:06
DateTime.Now.ToString("HH:mm") 	05:50 (Em and em (
DateTime.Now.ToString("hh: mm tt") 	05:50 AM
DateTime.Now.ToString("H:mm") 	5:50 (
DateTime.Now.ToString("h:mm tt) 	5:50 AM
DateTime.Now.ToString("HH:mm:ss") 	05:50:06 (Em uma versão: 5):
DateTime.Now.ToString("aaa MMMM") 	2015 Maio

    d: Representa o dia do mês como um número de 1 a 31.
    dd: Representa o dia do mês como um número de 01 a 31.
    ddd: Representa o nome abreviado do dia (Seg, Ter, Qua, etc).
    dddd: Representa o nome completo do dia (segunda-feira, terça-feira, etc).
    h: hora do relógio de 12 horas (por exemplo, 4).
    hh: relógio de 12 horas, com um líder 0 (p. ex. 06)
    H: hora do relógio de 24 horas (ex. 15)
    HH: hora do relógio 24 horas, com um líder 0 (p. ex. 22)
    m: Minutos
    mm: Minutos com um zero líder
    M: Número do mês (eg.3)
    MM: Número do mês com o zero da liderança (eg.04)
    MMM: Nome do mês abreviado (ex. Deciso)
    MMMM: nome completo do mês (e.g. Dezembro de 2015
    s: Segundos
    ss: Segundos com o zero
    t: Abreviado AM / PM (por exemplo, A ou P)
    tt: AM / PM (e.g. AM ou PM
    y: Ano, sem o primeiro zero (e.g. 2015 seria de 15 anos)
    yy: Ano, liderando zero (e.g. O ano de 2015 seria 015)
    yyy: Ano, (por exemplo, 2015 e Relatórios de interesse
    yyyy: Ano, (e.g. 2015 e Relatórios de interesse
    K: Representa as informações de fuso horário de um valor de data e hora (ex. +05:00)
    z: Com os valores de data-tempo representam o deslocamento assinado do fuso horário do sistema operacional local em que
    Tempo Universal Coordenado (UTC), medido em horas. (ex. +6)
    zz: Como z, mas com o zero (e.g. +06)
    zzz: Com os valores de data-tempo representam o deslocamento assinado do fuso horário do sistema operacional local a partir do UTC, medido em horas e minutos. +06:00)
    f: Representa o dígito mais significativo da fração de segundos; isto é, representa os décimos de segundo em um valor de data e hora.
    ff: Representa os dois dígitos mais significativos da fração do segundo em data e hora
    fff: Representa os três dígitos mais significativos da fração do segundo; isto é, representa os milissegundos em um valor de data e hora.
    ffff: Representa os quatro dígitos mais significativos da fração do segundo; isto é, representa os dez milésimos de segundo em um valor de data e hora. Embora seja possível exibir os décimos milionésimos de um segundo componente de um valor de tempo, esse valor pode não ser significativo.
    fffff: Representa os cinco dígitos mais significativos da fração do segundo; isto é, representa os cem milésimos de segundo em um valor de data e hora.
    ffffff: Representa os seis dígitos mais significativos da fração do segundo; isto é, representa o milionésimo de segundo em um valor de data e hora.
    fffffff: Representa os sete dígitos mais significativos da fração do segundo; isto é, representa os dez milionésimos de segundo em um valor de data e hora.
*/
