using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace fireResistance
{
    public class CreateDoc
    {
        public void Create(DataFireResistanceColumn data)
        {
            Word.Application wordApp = new Word.Application();
            
            Word.Document wordDocument;
            wordDocument = wordApp.Documents.Add();
            Word.Paragraphs wordParagraphs;
            Word.Paragraph wordParagraph;
            wordParagraphs = wordDocument.Paragraphs;
            wordParagraph = (Word.Paragraph)wordParagraphs[1];
            wordParagraph.Range.Text = $"\tПроверка предела огнестойкости пилона {data.heightElement}x{data.widthElement}";
            wordParagraph.Range.Font.Size = 10;
            wordParagraph.Range.Font.Name = "Times New Roman";
            wordParagraph.Range.Paragraphs.LineSpacing = 10;

            object oMissing = System.Reflection.Missing.Value;
            for (int i = 0; i < 3; i++)
            {
                wordDocument.Paragraphs.Add(ref oMissing);
            }


            wordParagraph = (Word.Paragraph)wordParagraphs[2];
            wordParagraph.Range.Text = $"Требуемый предел огнестойкости {data.fireResistanceVolume}";

            wordParagraph = (Word.Paragraph)wordParagraphs[3];
            wordParagraph.Range.Text = $"Длина элемента: \n" +
                $"\tL = {data.lenthElement} мм\n" +
                $"Высота сечения:\n" +
                $"\th = {data.heightElement} мм\n" +
                $"Ширина сечения:\n" +
                $"\tb = {data.widthElement} мм\n" +
                $"Закрепление по концам элемента:\n" +
                $" {data.fixationElement}\n" +
                $"Коэффициент расчетной длинны = {DataFromeSP468.FixationElementSheet[data.fixationElement]}\n" +
                $"Класс бетона по прочности {data.concreteClass}\n" +
                $"Класс арматуры по прочности:\n" +
                $"\t{data.armatureClass}\n" +
                $"Расстояние от грани элемента до центра тяжести арматуры:\n" +
                $"\ta = a' = {data.lenthFromArmatureToEdge} мм\n" +
                $"Диаметр продольной растянутой арматуры:\n" +
                $"\t{data.armatureDiameter} мм\n" +
                $"Количество арматурных стержней:\n" +
                $"\t{data.armatureAmount} шт.\n" +
                $"Площадь арматуры:\n" +
                $"\tAs = A's = {data.armatureSquare} мм^2\n" +
                $"Температура арматуры определенная по приложению Б СП468.1325800.2019 для угловых стержней \n" +
                $"\t{data.temperatureArmature} °С\n" +
                $"Температура прогрева бетона определенная в соответствии с п. 5.4 по приложению Б СП468.1325800.2019\n" +
                $"\t{data.temperatureConcrete} °С\n" +
                $"Изгибающий момент от постоянной и длительной нормативной нагрузки:\n" +
                $"\tMn = {Math.Round(data.moment, 2)} Н * мм = {data.moment * 0.00000010197162123} т * м\n" +
                $"Нормальная сила от постоянной и длительной нормативной нагрузки:\n" +
                $"\tNn = {Math.Round(data.strength, 2)} Н = {data.strength * 0.00010197162123} т\n" +
                $"Нормативное сопротивление бетона сжатию. Табл. 6.7, СП63.13330.2018:\n" +
                $"\tRbn = {data.concreteResistNormative} МПа\n" +
                $"Коэффициент условий работы бетона в соответствии с п. 8.7 СП468.1325800.2019:\n" +
                $"\tγbt = {data.gammaBT}\n" +
                $"Коэффициент βb Табл. 5.1, СП468.1325800.2019:\n" +
                $"\tβb = {data.betaB}\n" +
                $"Нормативное сопротивление бетона осевому сжатию с учетом изменения температуры ф.(5.1) СП468.1325800.2019\n" +
                $"\tRbnt = Rbn*γbt = {data.concreteResistWithTemperatureNormative} МПа\n" +
                $"Нормативное сопротивление арматуры растяжению. Табл. 6.13, СП63.13330.2018\n" +
                $"\tRsn = {data.armatureResistNormative} МПа\n" +
                $"Нормативное сопротивление арматуры растяжению при высокой температуре. Ф.(5.5) СП468.1325800.2019\n" +
                $"\tRsnt = Rsn*γst = {data.armatureResistWithTemperatureNormative} МПа\n" +
                $"Коэффициент условий работы арматуры. Табл. 5.6, СП468.1325800.2019\n" +
                $"\tγst = {data.gammaST}\n" +
                $"Коэффициент βs. Табл. 5.6, СП468.1325800.2019\n" +
                $"\tβs = {data.betaS}\n" +
                $"Расчетное сопротивление арматуры сжатию. Табл. 6.14, СП63.13330.2018\n" +
                $"\tRsc = {data.armatureResistSqueezeСalculation} МПа\n" +
                $"Расчетное сопротивление арматуры сжатию при высокой температуре. Ф.(5.6) СП468.1325800.2019\n" +
                $"\tRsct = Rsc*γst = {data.armatureResistSqueezeWithTemperatureСalculation} МПа\n" +
                $"Расчетное сопротивление арматуры растяжению. Табл. 6.14, СП63.13330.2018\n" +
                $"\tRs = {data.armatureResistStretchСalculation} МПа\n" +
                $"Расчетное сопротивление арматуры растяжению при высокой температуре. Ф.(5.6) СП468.1325800.2019\n" +
                $"\tRst = Rsc*γst = {data.armatureResistStretchWithTemperatureСalculation} МПа\n" +
                $"Модуль упругости арматуры. п. 6.2.12 СП63.13330.2018\n" +
                $"\tEs = {data.armatureElasticityModulus} МПа\n" +
                $"Начальный модуль упругости бетона. Табл. 6.11 СП63.13330.2018\n" +
                $"\tEb = {data.concreteStartElasticityModulus} МПа\n" +
                $"Глубина прогрева бетона до критической температуры. рис. 8.2 СП468.1325800.2019\n" +
                $"\tat = {data.deepConcreteWarming} мм\n" +
                $"Рабочая высота сечения\n" +
                $"\tho = h-a = {data.workHeight} мм\n" +
                $"Расчетная высота сечения при нагреве\n" +
                $"\tht = h-2*at = {data.heightProfileWithWarming} мм\n" +
                $"Расчетная ширина сечения при нагреве\n" +
                $"\tbt = b-2*at = {data.workWidthWithWarming} мм\n" +
                $"Площадь приведенного поперечного сечения. Ф.(8.8) СП468.1325800.2019\n" +
                $"\tAred = 0,9*(b-2*at)*(h-2*at) = {data.squareChangedProfile} мм^2\n" +
                $"Расчетная рабочая высота сечения при нагреве\n" +
                $"\th0t = h0-at = {data.workHeightProfileWithWarming} мм\n" +
                $"Случайный эксцентриситет\n" +
                $"\tеа = max(L/600;h/30;10) = {data.randomEccentricity} мм\n" +
                $"Эксцентриситет продольной силы относительно центра тяжести приведенного сечения с учетом п. 8.1.7 СП63.13330.2018\n" +
                $"\te0 = M/N = {data.eccentricityStrength} мм\n" +
                $"Относительное значение эксцентриситета продольной силы. п. 8.1.15 СП63.13330.2018\n" +
                $"\tδe = {data.relativelyEccentricityStrength}\n" +
                $"Расчетная длина элемента\n" +
                $"\tL0 = {data.workLenth} мм\n" +
                $"Коэф, учитывающий влияние длительности действия нагрузки. п. 8.1.15 СП63.13330.2018\n" +
                $"\tφl = {data.fiL}\n" +
                $"Момент инерции бетонного сечения относительно центра тяжести приведенного сечения\n" +
                $"\tI = bt*ht^3/12 = {data.momentOfInertiaConcrete} мм^4\n" +
                $"Момент инерции арматуры относительно центра тяжести сечения элемента\n" +
                $"\tIs = (As*(h-2*a)^2)/2 = {data.momentOfInertiaArmature} мм^4\n" +
                $"Модуль упругости арматуры при нагреве\n" +
                $"\tEst = Es*βs = {data.armatureElasticityModulusWithWarming} МПа\n" +
                $"Модуль упругости бетона при нагреве\n" +
                $"\tEbt = Eb*βb = {data.concreteElasticityModulusWithWarming} МПа\n" +
                $"Изгибная жесткость\n" +
                $"\tD = 0,15*Ebt*I/(φl*(0,3+δe))+0,7*Est*Is = {data.flexuralStiffness} мм\n" +
                $"Критическая сила\n" +
                $"\tNcr = π^2 * D/L0^2 = {data.strengthCritical} Н\n";

            if (!data.checkFirst)
            {
                wordParagraph = (Word.Paragraph)wordParagraphs[93];
                wordParagraph.Range.Text = $"Условие N ≤ Ncr\n" +
                    $"\t{Math.Round(data.strength, 2)} > {Math.Round(data.strengthCritical, 2)}\n" +
                    $"\t Условие НЕ выполнено!";
                wordApp.Visible = true;
                return;
            }

            wordParagraph = (Word.Paragraph)wordParagraphs[93];
            wordParagraph.Range.Text = $"Условие N ≤ Ncr\n" +
                $"\t{Math.Round(data.strength, 2)} ≤ {Math.Round(data.strengthCritical, 2)}\n" +
                $"\t Условие выполнено!\n" +
                $"Коэффициент учитывающий влияние прогиба п. 8.1.15 СП63.13330.2018\n" +
                $"\tη = 1/(1-N/Ncr) = {data.deflectionСoefficient}\n" +
                $"Расстояние от точки приложения силы N до центра тяжести сечения арматуры\n" +
                $"\te = e0*η + 0,5 * (h0t - a') + et = {data.finalEccentricity} мм\n" +
                $"Относительная деформация растянутой арматуры\n" +
                $"\tεs,el = Rst/Est = {data.relativeDeformationArmature}\n" +
                $"Относительная деформация сжатого бетона. п. 6.1.20 СП63.13330.2018\n" +
                $"\tεb2 = {data.relativeDeformationConcrete}\n" +
                $"Граничная относительная высота сжатой зоны\n" +
                $"\tξR = 0,8/(1+εs,el/εb2) = {data.boundaryRelativeHeightSqueezeZone}\n" +
                $"Высота сжатой зоны при  ξ ≤ ξR\n" +
                $"\txt = (N+Rsnt*As-Rsct*As)/Rbnt*bt = {data.heightSqueezeZoneFirst} мм\n" +
                $"Относительная высота сжатой зоны\n" +
                $"\tξ = xt/h0t = {data.relativeHeightSqueezeZone}\n";

            if (!data.checkSecond)
            {
                wordParagraph = (Word.Paragraph)wordParagraphs[110];
                wordParagraph.Range.Text = $"Условие ξ ≤ ξR\n" +
                    $"\t{data.relativeHeightSqueezeZone} > {data.boundaryRelativeHeightSqueezeZone}\n" +
                    $"\t Не выполнено!\n" +
                    $"Высота сжатой зоны при  ξ > ξR\n" +
                    $"\txt = (N+Rsnt*As*(1+ξR)/(1-ξR)-Rsct*A's)/(Rbnt*bt+2*Rsnt*As/(h0t*(1-ξR)) = {data.heightSqueezeZoneSecond} мм\n";
                wordParagraph = (Word.Paragraph)wordParagraphs[115];
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    wordDocument.Paragraphs.Add(ref oMissing);
                }
                wordParagraph = (Word.Paragraph)wordParagraphs[111];
            }


            if (data.checkthird)
            {
                wordParagraph.Range.Text = $"\n\n" +
                    $"Проверка условия обеспечения предела огнестойкости (формула 8.25 СП468.1325800.2019)\n" +
                    $"\tN*e ≤ Rbnt*bt*xt*(h0t-0,5*xt)+Rsct*A's*(h0-a')\n" +
                    $"\t{Math.Round(data.demandLeftPart, 1)} ≤ {Math.Round(data.demandRightPart, 1)}\n" +
                    $"\t Условие выполнено!\n" +
                    $"Коэффициент использования\n" +
                    $"\t{Math.Round(data.result, 3)}";
            }
            else
            {
                wordParagraph.Range.Text = $"Проверка условия обеспечения предела огнестойкости (формула 8.25 СП468.1325800.2019)\n" +
                    $"\tN*e ≤ Rbnt*bt*xt*(h0t-0,5*xt)+Rsct*A's*(h0-a')\n" +
                    $"\t{Math.Round(data.demandLeftPart,1)} > {Math.Round(data.demandRightPart, 1)}\n" +
                    $"\t Условие НЕ выполнено!\n" +
                    $"Коэффициент использования\n" +
                    $"\t{Math.Round(data.result, 3)}";
            }

            Word.Range wordRangeFirst = null;
            Word.Range wordRangeSecond = null;
            Word.Range wordRangeThird = null;
            for (int i = 1; i < wordDocument.Paragraphs.Count; i++)
            {
                string text = wordDocument.Paragraphs[i].Range.Text;
                if (!text.StartsWith("\t") || text.StartsWith(" "))
                {
                    wordRangeSecond = wordDocument.Paragraphs[i].Range;
                    wordRangeSecond.Select();
                    wordRangeSecond.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                }
                if (text.StartsWith("\t Условие выполнено!") || text.StartsWith("\t Условие НЕ выполнено!") || text.StartsWith($"\t{Math.Round(data.result, 3)}"))
                {
                    wordRangeThird = wordDocument.Paragraphs[i].Range;
                    wordRangeThird.Select();
                    wordRangeThird.Font.Bold = 1;
                }
                if (text.StartsWith("\tПроверка предела огнестойкости пилона"))
                {
                    wordRangeFirst = wordDocument.Paragraphs[i].Range;
                    wordRangeFirst.Select();
                    wordRangeFirst.Font.Bold = 1;
                    wordRangeFirst.Font.Size = 14;
                }


            }
            wordApp.Visible = true;




        }
    
    }
}
