using System;
using Src.Domain;
using Src.Domain.Enuns;
using Xunit;

namespace Test;

public class PressaoTest
{
    [Fact]
    public void CanIniciateClassWithIdNullTest()
    {
        PressaoArterial pressao = new(120, 80);
        Assert.Equal(120, pressao.PressaoArterialSistolica);
        Assert.Equal(80, pressao.PressaoArterialDiastalica);
        Assert.Null(pressao.PressaoArterialId);
    }

    [Fact]
    public void CanIniciateClassWithIdTest()
    {
        PressaoArterial pressao = new(1, 120, 80, DateTime.Now);
        Assert.Equal(120, pressao.PressaoArterialSistolica);
        Assert.Equal(80, pressao.PressaoArterialDiastalica);
        Assert.NotNull(pressao.PressaoArterialId);
    }

    [Theory]
    [InlineData(120, 80, ClassificacaoRisco.Normal)]
    [InlineData(129, 84, ClassificacaoRisco.Leve)]
    [InlineData(130, 85, ClassificacaoRisco.Leve)]
    [InlineData(140, 89, ClassificacaoRisco.Moderada)]
    [InlineData(160, 100, ClassificacaoRisco.Grave)]
    [InlineData(220, 120, ClassificacaoRisco.Grave)]
    [InlineData(110, 89, ClassificacaoRisco.Leve)]
    [InlineData(115, 80, ClassificacaoRisco.Normal)]
    public void CanClassificaoMedidaBeRigth(int sistolica, int diastolica, ClassificacaoRisco riscoMedicao)
    {
        PressaoArterial pressao = new(sistolica, diastolica);

        Assert.Equal(riscoMedicao, pressao.ClassificaoMedida);
    }

    [Fact]
    public void CanPressaoIniciateWithRigthDate() {
        PressaoArterial pressao = new(120, 80);
        Assert.Equal(DateTime.Now.Day, pressao.DataMedicao.Day);
    }

    [Fact]
    public void CanPressaoIniciateWithRigthDatePassed() {
        PressaoArterial pressao = new(1 ,120, 80, new DateTime(2020, 12, 5));
        Assert.Equal(2020, pressao.DataMedicao.Year);
        Assert.Equal(12, pressao.DataMedicao.Month);
        Assert.Equal(5, pressao.DataMedicao.Day);
    }
}