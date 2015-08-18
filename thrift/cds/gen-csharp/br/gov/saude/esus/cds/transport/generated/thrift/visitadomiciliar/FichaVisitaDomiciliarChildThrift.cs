/**
 * Autogenerated by Thrift Compiler (0.9.2)
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

namespace br.gov.saude.esus.cds.transport.generated.thrift.visitadomiciliar
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FichaVisitaDomiciliarChildThrift : TBase
  {
    private long _turno;
    private string _numProntuario;
    private string _numCartaoSus;
    private long _dtNascimento;
    private long _sexo;
    private bool _statusVisitaCompartilhadaOutroProfissional;
    private List<long> _motivosVisita;
    private long _desfecho;

    public long Turno
    {
      get
      {
        return _turno;
      }
      set
      {
        __isset.turno = true;
        this._turno = value;
      }
    }

    public string NumProntuario
    {
      get
      {
        return _numProntuario;
      }
      set
      {
        __isset.numProntuario = true;
        this._numProntuario = value;
      }
    }

    public string NumCartaoSus
    {
      get
      {
        return _numCartaoSus;
      }
      set
      {
        __isset.numCartaoSus = true;
        this._numCartaoSus = value;
      }
    }

    public long DtNascimento
    {
      get
      {
        return _dtNascimento;
      }
      set
      {
        __isset.dtNascimento = true;
        this._dtNascimento = value;
      }
    }

    public long Sexo
    {
      get
      {
        return _sexo;
      }
      set
      {
        __isset.sexo = true;
        this._sexo = value;
      }
    }

    public bool StatusVisitaCompartilhadaOutroProfissional
    {
      get
      {
        return _statusVisitaCompartilhadaOutroProfissional;
      }
      set
      {
        __isset.statusVisitaCompartilhadaOutroProfissional = true;
        this._statusVisitaCompartilhadaOutroProfissional = value;
      }
    }

    public List<long> MotivosVisita
    {
      get
      {
        return _motivosVisita;
      }
      set
      {
        __isset.motivosVisita = true;
        this._motivosVisita = value;
      }
    }

    public long Desfecho
    {
      get
      {
        return _desfecho;
      }
      set
      {
        __isset.desfecho = true;
        this._desfecho = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool turno;
      public bool numProntuario;
      public bool numCartaoSus;
      public bool dtNascimento;
      public bool sexo;
      public bool statusVisitaCompartilhadaOutroProfissional;
      public bool motivosVisita;
      public bool desfecho;
    }

    public FichaVisitaDomiciliarChildThrift() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.I64) {
              Turno = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              NumProntuario = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              NumCartaoSus = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I64) {
              DtNascimento = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              Sexo = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              StatusVisitaCompartilhadaOutroProfissional = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                MotivosVisita = new List<long>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  long _elem2;
                  _elem2 = iprot.ReadI64();
                  MotivosVisita.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              Desfecho = iprot.ReadI64();
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("FichaVisitaDomiciliarChildThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.turno) {
        field.Name = "turno";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Turno);
        oprot.WriteFieldEnd();
      }
      if (NumProntuario != null && __isset.numProntuario) {
        field.Name = "numProntuario";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NumProntuario);
        oprot.WriteFieldEnd();
      }
      if (NumCartaoSus != null && __isset.numCartaoSus) {
        field.Name = "numCartaoSus";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NumCartaoSus);
        oprot.WriteFieldEnd();
      }
      if (__isset.dtNascimento) {
        field.Name = "dtNascimento";
        field.Type = TType.I64;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(DtNascimento);
        oprot.WriteFieldEnd();
      }
      if (__isset.sexo) {
        field.Name = "sexo";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Sexo);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusVisitaCompartilhadaOutroProfissional) {
        field.Name = "statusVisitaCompartilhadaOutroProfissional";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusVisitaCompartilhadaOutroProfissional);
        oprot.WriteFieldEnd();
      }
      if (MotivosVisita != null && __isset.motivosVisita) {
        field.Name = "motivosVisita";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, MotivosVisita.Count));
          foreach (long _iter3 in MotivosVisita)
          {
            oprot.WriteI64(_iter3);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.desfecho) {
        field.Name = "desfecho";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Desfecho);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("FichaVisitaDomiciliarChildThrift(");
      bool __first = true;
      if (__isset.turno) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Turno: ");
        __sb.Append(Turno);
      }
      if (NumProntuario != null && __isset.numProntuario) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumProntuario: ");
        __sb.Append(NumProntuario);
      }
      if (NumCartaoSus != null && __isset.numCartaoSus) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumCartaoSus: ");
        __sb.Append(NumCartaoSus);
      }
      if (__isset.dtNascimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DtNascimento: ");
        __sb.Append(DtNascimento);
      }
      if (__isset.sexo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sexo: ");
        __sb.Append(Sexo);
      }
      if (__isset.statusVisitaCompartilhadaOutroProfissional) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusVisitaCompartilhadaOutroProfissional: ");
        __sb.Append(StatusVisitaCompartilhadaOutroProfissional);
      }
      if (MotivosVisita != null && __isset.motivosVisita) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MotivosVisita: ");
        __sb.Append(MotivosVisita);
      }
      if (__isset.desfecho) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Desfecho: ");
        __sb.Append(Desfecho);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
