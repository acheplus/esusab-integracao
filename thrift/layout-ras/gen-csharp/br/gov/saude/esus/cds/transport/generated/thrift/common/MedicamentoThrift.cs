/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esus.cds.transport.generated.thrift.common
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class MedicamentoThrift : TBase
  {
    private string _codigoCatmat;
    private long _viaAdministracao;
    private string _dose;
    private bool _doseUnica;
    private bool _usoContinuo;
    private long _doseFrequenciaTipo;
    private string _doseFrequencia;
    private int _doseFrequenciaQuantidade;
    private long _doseFrequenciaUnidadeMedida;
    private long _dtInicioTratamento;
    private int _duracaoTratamento;
    private long _duracaoTratamentoMedida;
    private int _quantidadeReceitada;

    public string CodigoCatmat
    {
      get
      {
        return _codigoCatmat;
      }
      set
      {
        __isset.codigoCatmat = true;
        this._codigoCatmat = value;
      }
    }

    public long ViaAdministracao
    {
      get
      {
        return _viaAdministracao;
      }
      set
      {
        __isset.viaAdministracao = true;
        this._viaAdministracao = value;
      }
    }

    public string Dose
    {
      get
      {
        return _dose;
      }
      set
      {
        __isset.dose = true;
        this._dose = value;
      }
    }

    public bool DoseUnica
    {
      get
      {
        return _doseUnica;
      }
      set
      {
        __isset.doseUnica = true;
        this._doseUnica = value;
      }
    }

    public bool UsoContinuo
    {
      get
      {
        return _usoContinuo;
      }
      set
      {
        __isset.usoContinuo = true;
        this._usoContinuo = value;
      }
    }

    public long DoseFrequenciaTipo
    {
      get
      {
        return _doseFrequenciaTipo;
      }
      set
      {
        __isset.doseFrequenciaTipo = true;
        this._doseFrequenciaTipo = value;
      }
    }

    public string DoseFrequencia
    {
      get
      {
        return _doseFrequencia;
      }
      set
      {
        __isset.doseFrequencia = true;
        this._doseFrequencia = value;
      }
    }

    public int DoseFrequenciaQuantidade
    {
      get
      {
        return _doseFrequenciaQuantidade;
      }
      set
      {
        __isset.doseFrequenciaQuantidade = true;
        this._doseFrequenciaQuantidade = value;
      }
    }

    public long DoseFrequenciaUnidadeMedida
    {
      get
      {
        return _doseFrequenciaUnidadeMedida;
      }
      set
      {
        __isset.doseFrequenciaUnidadeMedida = true;
        this._doseFrequenciaUnidadeMedida = value;
      }
    }

    public long DtInicioTratamento
    {
      get
      {
        return _dtInicioTratamento;
      }
      set
      {
        __isset.dtInicioTratamento = true;
        this._dtInicioTratamento = value;
      }
    }

    public int DuracaoTratamento
    {
      get
      {
        return _duracaoTratamento;
      }
      set
      {
        __isset.duracaoTratamento = true;
        this._duracaoTratamento = value;
      }
    }

    public long DuracaoTratamentoMedida
    {
      get
      {
        return _duracaoTratamentoMedida;
      }
      set
      {
        __isset.duracaoTratamentoMedida = true;
        this._duracaoTratamentoMedida = value;
      }
    }

    public int QuantidadeReceitada
    {
      get
      {
        return _quantidadeReceitada;
      }
      set
      {
        __isset.quantidadeReceitada = true;
        this._quantidadeReceitada = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool codigoCatmat;
      public bool viaAdministracao;
      public bool dose;
      public bool doseUnica;
      public bool usoContinuo;
      public bool doseFrequenciaTipo;
      public bool doseFrequencia;
      public bool doseFrequenciaQuantidade;
      public bool doseFrequenciaUnidadeMedida;
      public bool dtInicioTratamento;
      public bool duracaoTratamento;
      public bool duracaoTratamentoMedida;
      public bool quantidadeReceitada;
    }

    public MedicamentoThrift() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                CodigoCatmat = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I64) {
                ViaAdministracao = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Dose = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                DoseUnica = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Bool) {
                UsoContinuo = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                DoseFrequenciaTipo = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                DoseFrequencia = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I32) {
                DoseFrequenciaQuantidade = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I64) {
                DoseFrequenciaUnidadeMedida = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.I64) {
                DtInicioTratamento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.I32) {
                DuracaoTratamento = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.I64) {
                DuracaoTratamentoMedida = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 13:
              if (field.Type == TType.I32) {
                QuantidadeReceitada = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("MedicamentoThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (CodigoCatmat != null && __isset.codigoCatmat) {
          field.Name = "codigoCatmat";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CodigoCatmat);
          oprot.WriteFieldEnd();
        }
        if (__isset.viaAdministracao) {
          field.Name = "viaAdministracao";
          field.Type = TType.I64;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(ViaAdministracao);
          oprot.WriteFieldEnd();
        }
        if (Dose != null && __isset.dose) {
          field.Name = "dose";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Dose);
          oprot.WriteFieldEnd();
        }
        if (__isset.doseUnica) {
          field.Name = "doseUnica";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(DoseUnica);
          oprot.WriteFieldEnd();
        }
        if (__isset.usoContinuo) {
          field.Name = "usoContinuo";
          field.Type = TType.Bool;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(UsoContinuo);
          oprot.WriteFieldEnd();
        }
        if (__isset.doseFrequenciaTipo) {
          field.Name = "doseFrequenciaTipo";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DoseFrequenciaTipo);
          oprot.WriteFieldEnd();
        }
        if (DoseFrequencia != null && __isset.doseFrequencia) {
          field.Name = "doseFrequencia";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DoseFrequencia);
          oprot.WriteFieldEnd();
        }
        if (__isset.doseFrequenciaQuantidade) {
          field.Name = "doseFrequenciaQuantidade";
          field.Type = TType.I32;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(DoseFrequenciaQuantidade);
          oprot.WriteFieldEnd();
        }
        if (__isset.doseFrequenciaUnidadeMedida) {
          field.Name = "doseFrequenciaUnidadeMedida";
          field.Type = TType.I64;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DoseFrequenciaUnidadeMedida);
          oprot.WriteFieldEnd();
        }
        if (__isset.dtInicioTratamento) {
          field.Name = "dtInicioTratamento";
          field.Type = TType.I64;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DtInicioTratamento);
          oprot.WriteFieldEnd();
        }
        if (__isset.duracaoTratamento) {
          field.Name = "duracaoTratamento";
          field.Type = TType.I32;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(DuracaoTratamento);
          oprot.WriteFieldEnd();
        }
        if (__isset.duracaoTratamentoMedida) {
          field.Name = "duracaoTratamentoMedida";
          field.Type = TType.I64;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DuracaoTratamentoMedida);
          oprot.WriteFieldEnd();
        }
        if (__isset.quantidadeReceitada) {
          field.Name = "quantidadeReceitada";
          field.Type = TType.I32;
          field.ID = 13;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(QuantidadeReceitada);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("MedicamentoThrift(");
      bool __first = true;
      if (CodigoCatmat != null && __isset.codigoCatmat) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CodigoCatmat: ");
        __sb.Append(CodigoCatmat);
      }
      if (__isset.viaAdministracao) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ViaAdministracao: ");
        __sb.Append(ViaAdministracao);
      }
      if (Dose != null && __isset.dose) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dose: ");
        __sb.Append(Dose);
      }
      if (__isset.doseUnica) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoseUnica: ");
        __sb.Append(DoseUnica);
      }
      if (__isset.usoContinuo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UsoContinuo: ");
        __sb.Append(UsoContinuo);
      }
      if (__isset.doseFrequenciaTipo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoseFrequenciaTipo: ");
        __sb.Append(DoseFrequenciaTipo);
      }
      if (DoseFrequencia != null && __isset.doseFrequencia) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoseFrequencia: ");
        __sb.Append(DoseFrequencia);
      }
      if (__isset.doseFrequenciaQuantidade) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoseFrequenciaQuantidade: ");
        __sb.Append(DoseFrequenciaQuantidade);
      }
      if (__isset.doseFrequenciaUnidadeMedida) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoseFrequenciaUnidadeMedida: ");
        __sb.Append(DoseFrequenciaUnidadeMedida);
      }
      if (__isset.dtInicioTratamento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DtInicioTratamento: ");
        __sb.Append(DtInicioTratamento);
      }
      if (__isset.duracaoTratamento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DuracaoTratamento: ");
        __sb.Append(DuracaoTratamento);
      }
      if (__isset.duracaoTratamentoMedida) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DuracaoTratamentoMedida: ");
        __sb.Append(DuracaoTratamentoMedida);
      }
      if (__isset.quantidadeReceitada) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("QuantidadeReceitada: ");
        __sb.Append(QuantidadeReceitada);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}