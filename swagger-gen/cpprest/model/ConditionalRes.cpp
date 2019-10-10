/**
 * Bybit API
 * ## REST API for the Bybit Exchange. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.8.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */



#include "ConditionalRes.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

ConditionalRes::ConditionalRes()
{
    m_Stop_order_id = utility::conversions::to_string_t("");
    m_Stop_order_idIsSet = false;
    m_User_id = 0.0;
    m_User_idIsSet = false;
    m_Stop_order_status = utility::conversions::to_string_t("");
    m_Stop_order_statusIsSet = false;
    m_Symbol = utility::conversions::to_string_t("");
    m_SymbolIsSet = false;
    m_Side = utility::conversions::to_string_t("");
    m_SideIsSet = false;
    m_Order_type = utility::conversions::to_string_t("");
    m_Order_typeIsSet = false;
    m_Price = 0.0;
    m_PriceIsSet = false;
    m_Qty = 0.0;
    m_QtyIsSet = false;
    m_Time_in_force = utility::conversions::to_string_t("");
    m_Time_in_forceIsSet = false;
    m_Stop_order_type = utility::conversions::to_string_t("");
    m_Stop_order_typeIsSet = false;
    m_Base_price = 0.0;
    m_Base_priceIsSet = false;
    m_Stop_px = 0.0;
    m_Stop_pxIsSet = false;
    m_Order_link_id = utility::conversions::to_string_t("");
    m_Order_link_idIsSet = false;
    m_Created_at = utility::conversions::to_string_t("");
    m_Created_atIsSet = false;
    m_Updated_at = utility::conversions::to_string_t("");
    m_Updated_atIsSet = false;
}

ConditionalRes::~ConditionalRes()
{
}

void ConditionalRes::validate()
{
    // TODO: implement validation
}

web::json::value ConditionalRes::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_Stop_order_idIsSet)
    {
        val[utility::conversions::to_string_t("stop_order_id")] = ModelBase::toJson(m_Stop_order_id);
    }
    if(m_User_idIsSet)
    {
        val[utility::conversions::to_string_t("user_id")] = ModelBase::toJson(m_User_id);
    }
    if(m_Stop_order_statusIsSet)
    {
        val[utility::conversions::to_string_t("stop_order_status")] = ModelBase::toJson(m_Stop_order_status);
    }
    if(m_SymbolIsSet)
    {
        val[utility::conversions::to_string_t("symbol")] = ModelBase::toJson(m_Symbol);
    }
    if(m_SideIsSet)
    {
        val[utility::conversions::to_string_t("side")] = ModelBase::toJson(m_Side);
    }
    if(m_Order_typeIsSet)
    {
        val[utility::conversions::to_string_t("order_type")] = ModelBase::toJson(m_Order_type);
    }
    if(m_PriceIsSet)
    {
        val[utility::conversions::to_string_t("price")] = ModelBase::toJson(m_Price);
    }
    if(m_QtyIsSet)
    {
        val[utility::conversions::to_string_t("qty")] = ModelBase::toJson(m_Qty);
    }
    if(m_Time_in_forceIsSet)
    {
        val[utility::conversions::to_string_t("time_in_force")] = ModelBase::toJson(m_Time_in_force);
    }
    if(m_Stop_order_typeIsSet)
    {
        val[utility::conversions::to_string_t("stop_order_type")] = ModelBase::toJson(m_Stop_order_type);
    }
    if(m_Base_priceIsSet)
    {
        val[utility::conversions::to_string_t("base_price")] = ModelBase::toJson(m_Base_price);
    }
    if(m_Stop_pxIsSet)
    {
        val[utility::conversions::to_string_t("stop_px")] = ModelBase::toJson(m_Stop_px);
    }
    if(m_Order_link_idIsSet)
    {
        val[utility::conversions::to_string_t("order_link_id")] = ModelBase::toJson(m_Order_link_id);
    }
    if(m_Created_atIsSet)
    {
        val[utility::conversions::to_string_t("created_at")] = ModelBase::toJson(m_Created_at);
    }
    if(m_Updated_atIsSet)
    {
        val[utility::conversions::to_string_t("updated_at")] = ModelBase::toJson(m_Updated_at);
    }

    return val;
}

void ConditionalRes::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("stop_order_id")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("stop_order_id")];
        if(!fieldValue.is_null())
        {
            setStopOrderId(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("user_id")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("user_id")];
        if(!fieldValue.is_null())
        {
            setUserId(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("stop_order_status")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("stop_order_status")];
        if(!fieldValue.is_null())
        {
            setStopOrderStatus(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("symbol")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("symbol")];
        if(!fieldValue.is_null())
        {
            setSymbol(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("side")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("side")];
        if(!fieldValue.is_null())
        {
            setSide(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("order_type")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("order_type")];
        if(!fieldValue.is_null())
        {
            setOrderType(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("price")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("price")];
        if(!fieldValue.is_null())
        {
            setPrice(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("qty")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("qty")];
        if(!fieldValue.is_null())
        {
            setQty(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("time_in_force")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("time_in_force")];
        if(!fieldValue.is_null())
        {
            setTimeInForce(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("stop_order_type")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("stop_order_type")];
        if(!fieldValue.is_null())
        {
            setStopOrderType(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("base_price")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("base_price")];
        if(!fieldValue.is_null())
        {
            setBasePrice(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("stop_px")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("stop_px")];
        if(!fieldValue.is_null())
        {
            setStopPx(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("order_link_id")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("order_link_id")];
        if(!fieldValue.is_null())
        {
            setOrderLinkId(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("created_at")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("created_at")];
        if(!fieldValue.is_null())
        {
            setCreatedAt(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("updated_at")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("updated_at")];
        if(!fieldValue.is_null())
        {
            setUpdatedAt(ModelBase::stringFromJson(fieldValue));
        }
    }
}

void ConditionalRes::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(m_Stop_order_idIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("stop_order_id"), m_Stop_order_id));
        
    }
    if(m_User_idIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("user_id"), m_User_id));
    }
    if(m_Stop_order_statusIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("stop_order_status"), m_Stop_order_status));
        
    }
    if(m_SymbolIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("symbol"), m_Symbol));
        
    }
    if(m_SideIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("side"), m_Side));
        
    }
    if(m_Order_typeIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("order_type"), m_Order_type));
        
    }
    if(m_PriceIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("price"), m_Price));
    }
    if(m_QtyIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("qty"), m_Qty));
    }
    if(m_Time_in_forceIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("time_in_force"), m_Time_in_force));
        
    }
    if(m_Stop_order_typeIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("stop_order_type"), m_Stop_order_type));
        
    }
    if(m_Base_priceIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("base_price"), m_Base_price));
    }
    if(m_Stop_pxIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("stop_px"), m_Stop_px));
    }
    if(m_Order_link_idIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("order_link_id"), m_Order_link_id));
        
    }
    if(m_Created_atIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("created_at"), m_Created_at));
        
    }
    if(m_Updated_atIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("updated_at"), m_Updated_at));
        
    }
}

void ConditionalRes::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(multipart->hasContent(utility::conversions::to_string_t("stop_order_id")))
    {
        setStopOrderId(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("stop_order_id"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("user_id")))
    {
        setUserId(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("user_id"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("stop_order_status")))
    {
        setStopOrderStatus(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("stop_order_status"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("symbol")))
    {
        setSymbol(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("symbol"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("side")))
    {
        setSide(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("side"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("order_type")))
    {
        setOrderType(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("order_type"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("price")))
    {
        setPrice(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("price"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("qty")))
    {
        setQty(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("qty"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("time_in_force")))
    {
        setTimeInForce(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("time_in_force"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("stop_order_type")))
    {
        setStopOrderType(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("stop_order_type"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("base_price")))
    {
        setBasePrice(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("base_price"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("stop_px")))
    {
        setStopPx(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("stop_px"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("order_link_id")))
    {
        setOrderLinkId(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("order_link_id"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("created_at")))
    {
        setCreatedAt(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("created_at"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("updated_at")))
    {
        setUpdatedAt(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("updated_at"))));
    }
}

utility::string_t ConditionalRes::getStopOrderId() const
{
    return m_Stop_order_id;
}


void ConditionalRes::setStopOrderId(utility::string_t value)
{
    m_Stop_order_id = value;
    m_Stop_order_idIsSet = true;
}
bool ConditionalRes::stopOrderIdIsSet() const
{
    return m_Stop_order_idIsSet;
}

void ConditionalRes::unsetStop_order_id()
{
    m_Stop_order_idIsSet = false;
}

double ConditionalRes::getUserId() const
{
    return m_User_id;
}


void ConditionalRes::setUserId(double value)
{
    m_User_id = value;
    m_User_idIsSet = true;
}
bool ConditionalRes::userIdIsSet() const
{
    return m_User_idIsSet;
}

void ConditionalRes::unsetUser_id()
{
    m_User_idIsSet = false;
}

utility::string_t ConditionalRes::getStopOrderStatus() const
{
    return m_Stop_order_status;
}


void ConditionalRes::setStopOrderStatus(utility::string_t value)
{
    m_Stop_order_status = value;
    m_Stop_order_statusIsSet = true;
}
bool ConditionalRes::stopOrderStatusIsSet() const
{
    return m_Stop_order_statusIsSet;
}

void ConditionalRes::unsetStop_order_status()
{
    m_Stop_order_statusIsSet = false;
}

utility::string_t ConditionalRes::getSymbol() const
{
    return m_Symbol;
}


void ConditionalRes::setSymbol(utility::string_t value)
{
    m_Symbol = value;
    m_SymbolIsSet = true;
}
bool ConditionalRes::symbolIsSet() const
{
    return m_SymbolIsSet;
}

void ConditionalRes::unsetSymbol()
{
    m_SymbolIsSet = false;
}

utility::string_t ConditionalRes::getSide() const
{
    return m_Side;
}


void ConditionalRes::setSide(utility::string_t value)
{
    m_Side = value;
    m_SideIsSet = true;
}
bool ConditionalRes::sideIsSet() const
{
    return m_SideIsSet;
}

void ConditionalRes::unsetSide()
{
    m_SideIsSet = false;
}

utility::string_t ConditionalRes::getOrderType() const
{
    return m_Order_type;
}


void ConditionalRes::setOrderType(utility::string_t value)
{
    m_Order_type = value;
    m_Order_typeIsSet = true;
}
bool ConditionalRes::orderTypeIsSet() const
{
    return m_Order_typeIsSet;
}

void ConditionalRes::unsetOrder_type()
{
    m_Order_typeIsSet = false;
}

double ConditionalRes::getPrice() const
{
    return m_Price;
}


void ConditionalRes::setPrice(double value)
{
    m_Price = value;
    m_PriceIsSet = true;
}
bool ConditionalRes::priceIsSet() const
{
    return m_PriceIsSet;
}

void ConditionalRes::unsetPrice()
{
    m_PriceIsSet = false;
}

double ConditionalRes::getQty() const
{
    return m_Qty;
}


void ConditionalRes::setQty(double value)
{
    m_Qty = value;
    m_QtyIsSet = true;
}
bool ConditionalRes::qtyIsSet() const
{
    return m_QtyIsSet;
}

void ConditionalRes::unsetQty()
{
    m_QtyIsSet = false;
}

utility::string_t ConditionalRes::getTimeInForce() const
{
    return m_Time_in_force;
}


void ConditionalRes::setTimeInForce(utility::string_t value)
{
    m_Time_in_force = value;
    m_Time_in_forceIsSet = true;
}
bool ConditionalRes::timeInForceIsSet() const
{
    return m_Time_in_forceIsSet;
}

void ConditionalRes::unsetTime_in_force()
{
    m_Time_in_forceIsSet = false;
}

utility::string_t ConditionalRes::getStopOrderType() const
{
    return m_Stop_order_type;
}


void ConditionalRes::setStopOrderType(utility::string_t value)
{
    m_Stop_order_type = value;
    m_Stop_order_typeIsSet = true;
}
bool ConditionalRes::stopOrderTypeIsSet() const
{
    return m_Stop_order_typeIsSet;
}

void ConditionalRes::unsetStop_order_type()
{
    m_Stop_order_typeIsSet = false;
}

double ConditionalRes::getBasePrice() const
{
    return m_Base_price;
}


void ConditionalRes::setBasePrice(double value)
{
    m_Base_price = value;
    m_Base_priceIsSet = true;
}
bool ConditionalRes::basePriceIsSet() const
{
    return m_Base_priceIsSet;
}

void ConditionalRes::unsetBase_price()
{
    m_Base_priceIsSet = false;
}

double ConditionalRes::getStopPx() const
{
    return m_Stop_px;
}


void ConditionalRes::setStopPx(double value)
{
    m_Stop_px = value;
    m_Stop_pxIsSet = true;
}
bool ConditionalRes::stopPxIsSet() const
{
    return m_Stop_pxIsSet;
}

void ConditionalRes::unsetStop_px()
{
    m_Stop_pxIsSet = false;
}

utility::string_t ConditionalRes::getOrderLinkId() const
{
    return m_Order_link_id;
}


void ConditionalRes::setOrderLinkId(utility::string_t value)
{
    m_Order_link_id = value;
    m_Order_link_idIsSet = true;
}
bool ConditionalRes::orderLinkIdIsSet() const
{
    return m_Order_link_idIsSet;
}

void ConditionalRes::unsetOrder_link_id()
{
    m_Order_link_idIsSet = false;
}

utility::string_t ConditionalRes::getCreatedAt() const
{
    return m_Created_at;
}


void ConditionalRes::setCreatedAt(utility::string_t value)
{
    m_Created_at = value;
    m_Created_atIsSet = true;
}
bool ConditionalRes::createdAtIsSet() const
{
    return m_Created_atIsSet;
}

void ConditionalRes::unsetCreated_at()
{
    m_Created_atIsSet = false;
}

utility::string_t ConditionalRes::getUpdatedAt() const
{
    return m_Updated_at;
}


void ConditionalRes::setUpdatedAt(utility::string_t value)
{
    m_Updated_at = value;
    m_Updated_atIsSet = true;
}
bool ConditionalRes::updatedAtIsSet() const
{
    return m_Updated_atIsSet;
}

void ConditionalRes::unsetUpdated_at()
{
    m_Updated_atIsSet = false;
}

}
}
}
}
