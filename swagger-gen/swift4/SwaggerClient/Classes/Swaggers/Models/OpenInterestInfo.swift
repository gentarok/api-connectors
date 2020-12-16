//
// OpenInterestInfo.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct OpenInterestInfo: Codable {

    public var openInterest: Int?
    public var timestamp: Int?
    public var symbol: String?

    public init(openInterest: Int?, timestamp: Int?, symbol: String?) {
        self.openInterest = openInterest
        self.timestamp = timestamp
        self.symbol = symbol
    }

    public enum CodingKeys: String, CodingKey { 
        case openInterest = "open_interest"
        case timestamp
        case symbol
    }


}
